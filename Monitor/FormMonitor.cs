using IBLeier.VictronEnergy.Monitor;
using ModbusTcp;
using Monitor.Properties;
using Monitor.VrmApi.Models;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Monitor
{
	public partial class FormMonitor : Form
	{
		public FormMonitor()
		{
			InitializeComponent();

			// https://www.howsmyssl.com/a/check
			ServicePointManager.SecurityProtocol = /*SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | */ SecurityProtocolType.Tls12;

#if DEBUG
			this.timer1.Interval = 1000;
#else
			this.timer1.Interval = Settings.Default.TimerInterval * 1000;
#endif
		}

		int count = 0;

		private void FormMonitor_Load(object sender, EventArgs e)
		{
			try
			{
				this.Timer1_Tick();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "FormMonitor_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.Timer1_Tick();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Timer1_Tick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				this.Timer2_Tick();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Timer2_Tick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string lastExceptionName;

		private async void Timer1_Tick()
		{
			this.timer1.Stop();

			InstallationsOKResponse installationsOKResponse;
			try
			{
				installationsOKResponse = await VrmController.GetInstallationsAsync();
				this.lastExceptionName = null;
			}
			catch (Exception ex)
			{
				this.Fill(ex);

				string name = ex.GetType().Name;
				if (this.lastExceptionName != name)
				{
					this.lastExceptionName = name;
					MessageBox.Show(ex.ToString(), "GetInstallationsAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				this.timer1.Start();
				return;
			}

			double bv = this.Fill(installationsOKResponse);

#if DEBUG
			Check check = null;
#else
			Check check = Check.CheckVoltage(bv);
#endif
			if (check != null)
			{
				this.TopMost = true;
				MessageBox.Show(bv + " V < " + check.low + " V !!!", "Spannung zu niedrig !!!", MessageBoxButtons.OK, check.icon);
				this.TopMost = false;
			}

			this.timer1.Start();
			return;
		}

		private void Fill(Exception exception)
		{
			string description = DateTime.Now.ToLongTimeString();
			string formattedValue = null;
			this.dataGridView1.Rows.Insert(0, description, formattedValue);

			Exception ex = exception;
			do
			{
				description = ex.GetType().Name;
				formattedValue = ex.Message;
				this.dataGridView1.Rows.Insert(0, description, formattedValue);

				ex = ex.InnerException;
			} while (ex != null);
		}

		private long lastTimestamp;
		private DateTime lastTimestampDate;

		private double Fill(InstallationsOKResponse installationsOKResponse)
		{
			double bv = 0;
			var site = installationsOKResponse.Records.First();

			this.dataGridView1.Rows.Clear();
			foreach (var item in site.Extended)
			{
				var code = item.Code;
				if (code == "bv")
				{
					var rawValue = item.RawValue;
					bv = Convert.ToDouble(rawValue, CultureInfo.InvariantCulture);
					//bv = 23;
				}

				var description = item.Description;
				var formattedValue = item.FormattedValue;
				//formattedValue = this.bv.ToString();

				if (!string.IsNullOrEmpty(formattedValue) && !formattedValue.StartsWith("Not"))
				{
					//Console.WriteLine(description + ": " + formattedValue);
					this.dataGridView1.Rows.Add(description, formattedValue);
				}
			}

			long syscreated = site.Syscreated.Value;
			DateTime sc = DateTimeOffset.FromUnixTimeSeconds(syscreated).LocalDateTime;
			this.dataGridView1.Rows.Add("syscreated", sc.ToString());

			long lastTimestamp = site.LastTimestamp.Value;
			DateTime lt = DateTimeOffset.FromUnixTimeSeconds(lastTimestamp).LocalDateTime;
			this.dataGridView1.Rows.Add("last_timestamp", lt.ToString());
			if (this.lastTimestamp != lastTimestamp && !this.timer2.Enabled)
			{
#if DEBUG
				this.dailyInit = this.lastTimestampDate != lt.Date;
#endif
				this.lastTimestamp = lastTimestamp;
				this.lastTimestampDate = lt.Date;
				this.step = 1;
				Logging.Log("FormMonitor.Fill", "Start, " + lt + ", " + (DateTime.Now - lt));
				this.timer2.Start();
			}

			string currentTime = site.CurrentTime;
			this.dataGridView1.Rows.Add("current_time", currentTime);

			this.dataGridView1.Rows.Add("count", ++count);

			return bv;
		}

		private void FormMonitor_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.timer1.Stop();
			this.timer2.Stop();
			Console.WriteLine("FormMonitor_FormClosed: Stop.");
		}

		private int step;
		private bool dailyInit;

		private void Timer2_Tick()
		{
			SolarChargerData scData = new SolarChargerData(239);
			ChargerOnOffData coData = new ChargerOnOffData(239);

			using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
			{
				string returnValue = adapter.Connect("venus", 502);
				if (!string.IsNullOrEmpty(returnValue))
				{
					this.timer2.Stop();
					Logging.Log("FormMonitor.Timer2_Tick-Error", returnValue);
					this.step = 0;
					return;
				}

				int count = adapter.Fill(scData);
				string message = null;
				message += "step: " + this.step + ", count: " + count + ", dailyInit: " + this.dailyInit + " - ";
				message += "PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ";
				message += "Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode;
				Trace.WriteLine(message);
				Logging.Log("FormMonitor.Timer2_Tick-Fill", message);

				// 1. Charger is On and working
				if (this.step == 1 && scData.ChargerOnOff == 1 && scData.ChargeState != 0)
				{
					if (scData.PvCurrent < 0.1 || scData.PvPower < 0.1 || this.dailyInit)
					{
						this.dailyInit = false;

						// Switch Off
						coData.ChargerOnOff = 4;
						count = adapter.Write(coData);
						Logging.Log("FormMonitor.Timer2_Tick-Write", "Switch Off: " + count);
						this.step = 2;
					}
					else
					{
						// stop timer 2
						this.timer2.Stop();
						Logging.Log("FormMonitor.Timer2_Tick", "Stop1");
						this.step = 0;
					}
				}

				// 2. Charger is Off and not working
				if (this.step != 3 && scData.ChargerOnOff == 4 && scData.ChargeState == 0)
				{
					// Switch On
					coData.ChargerOnOff = 1;
					count = adapter.Write(coData);
					Logging.Log("FormMonitor.Timer2_Tick-Write", "Switch On: " + count);
					this.step = 3;
				}

				// 3. Charger is On. working isn't necessary
				if (this.step == 3 && scData.ChargerOnOff == 1)
				{
					// stop timer 2
					this.timer2.Stop();
					Logging.Log("FormMonitor.Timer2_Tick", "Stop2");
					this.step = 0;
				}
			}
		}
	}
}
