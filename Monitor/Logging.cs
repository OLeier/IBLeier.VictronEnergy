using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using Monitor.Properties;

namespace IBLeier.VictronEnergy.Monitor
{
    internal static class Logging
    {
        static readonly object lockObject = new object();
        static string oldPathLog;
        static string oldPathErrorLog;

        public static void Log(string methode, string nachricht)
        {
            lock (Logging.lockObject)
            {
                DateTime now = DateTime.Now;
                string info = string.Format(CultureInfo.InvariantCulture, "{0:s},{1:fff};{2};{3};{4}\r\n",
                    now, now, Thread.CurrentThread.ManagedThreadId, methode, nachricht);

                Console.Write(info);
                Trace.Write(info);

                string fn = string.Format(CultureInfo.InvariantCulture, Settings.Default.LoggingFile, now);
                if (Logging.oldPathLog != fn)
                {
                    Logging.oldPathLog = fn;
                    File.AppendAllText(fn, "DateTime;ManagedThreadId;Methode;Nachricht\r\n");
                }

                //Trace.WriteLine(fn);
                File.AppendAllText(fn, info);
            }
        }

        public static void ErrorLog(string methode, string nachricht)
        {
            lock (Logging.lockObject)
            {
                DateTime now = DateTime.Now;
                string info = string.Format(CultureInfo.InvariantCulture, "{0:s},{1:fff};{2};{3};{4}\r\n",
                    now, now, Thread.CurrentThread.ManagedThreadId, methode, nachricht);

                string fn = string.Format(CultureInfo.InvariantCulture, Settings.Default.LoggingFile, now);
                fn = fn.Replace("DataCollector", "Error");
                if (Logging.oldPathErrorLog != fn)
                {
                    Logging.oldPathErrorLog = fn;
                    File.AppendAllText(fn, "DateTime;ManagedThreadId;Methode;Nachricht\r\n");
                }

                File.AppendAllText(fn, info);
            }
        }
    }
}
