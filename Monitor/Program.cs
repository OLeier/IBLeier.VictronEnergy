using IBLeier.VictronEnergy.Monitor;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Monitor
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Logging.Log("Main", "Hello Monitor - Start! " + args.Length + ", " + string.Join(",", args));
			Logging.Log("Main", "Is64BitOperatingSystem: " + Environment.Is64BitOperatingSystem + ", Is64BitProcess: " + Environment.Is64BitProcess);

			// Add the event handler for handling UI thread exceptions to the event.
			Application.ThreadException += Application_ThreadException;
			// Set the unhandled exception mode to force all Windows Forms errors to go through
			// our handler.
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			// Add the event handler for handling non-UI thread exceptions to the event.
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMonitor());

			Logging.Log("Main", "Stop!");
		}

		// Handle the UI exceptions by showing a dialog box, and asking the user whether
		// or not they wish to abort execution.
		// NOTE: This exception cannot be kept from terminating the application - it can only
		// log the event, and inform the user about it.
		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			try
			{
				Exception ex = (Exception)e.ExceptionObject;
				string errorMsg = "An application error occurred. Please contact the adminstrator " +
					"with the following information:\n\n";

				// Since we can't prevent the app from terminating, log this to the event log.
				if (!EventLog.SourceExists("ThreadException"))
				{
					EventLog.CreateEventSource("ThreadException", "Application");
				}

				// Create an EventLog instance and assign its source.
				EventLog myLog = new EventLog()
				{
					Source = "ThreadException",
				};
				myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
				Logging.Log("CurrentDomain_UnhandledException", ex.ToString());
			}
			catch (Exception exc)
			{
				try
				{
					Logging.Log("CurrentDomain_UnhandledException", exc.ToString());
					MessageBox.Show("Fatal Non-UI Error",
						"Fatal Non-UI Error. Could not write the error to the event log. Reason: "
						+ exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				finally
				{
					Application.Exit();
				}
			}
		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			Logging.Log("Application_ThreadException", e.Exception.ToString());
			Application.Exit();
		}
	}
}
