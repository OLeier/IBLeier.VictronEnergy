using IBLeier.VictronEnergy.Monitor;
using System;
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

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMonitor());

			Logging.Log("Main", "Stop!");
		}
	}
}
