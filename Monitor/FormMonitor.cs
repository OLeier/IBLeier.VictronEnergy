using IBLeier.VictronEnergy.ModbusTcp;
using IBLeier.VictronEnergy.Monitor;
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
		private bool formClosing;

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
			this.timer2.Interval = Settings.Default.ModbusTimerInterval * 1000;
		}

		int count = 0;

		private void FormMonitor_Load(object sender, EventArgs e)
		{
			try
			{
				this.Timer1_Tick(sender: null, e: null);
			}
			catch (Exception ex)
			{
				Logging.Log("FormMonitor_Load", ex.ToString());
				MessageBox.Show(ex.ToString(), "FormMonitor_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string lastExceptionName;

		private async void Timer1_Tick(object sender, EventArgs e)
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
				Logging.Log("Timer1_Tick-async", ex.ToString());
				this.Fill(ex);

				string name = ex.GetType().Name;
				if (this.lastExceptionName != name)
				{
					this.lastExceptionName = name;
					MessageBox.Show(ex.ToString(), "GetInstallationsAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				installationsOKResponse = null;
			}

			if (!this.formClosing)
			{
				if (installationsOKResponse != null)
				{
					try
					{
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
					}
					catch (Exception ex)
					{
						Logging.Log("Timer1_Tick", ex.ToString());
						MessageBox.Show(ex.ToString(), "Timer1_Tick", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				this.timer1.Start();
			}
			return;
		}

		private void Fill(Exception exception)
		{
			Logging.Log("Fill-Exception", "Begin");
			string description = DateTime.Now.ToLongTimeString();
			string formattedValue = null;
			this.dataGridView1.Rows.Insert(0, description, formattedValue);

			Exception ex = exception;
			do
			{
				Logging.Log("Fill-exception", ex.ToString());
				description = ex.GetType().Name;
				formattedValue = ex.Message;
				this.dataGridView1.Rows.Insert(0, description, formattedValue);

				ex = ex.InnerException;
			} while (ex != null);
			Logging.Log("Fill-Exception", "End");
		}

		private double Fill(InstallationsOKResponse installationsOKResponse)
		{
			Logging.Log("Fill-InstallationsOKResponse", "Begin");
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
			this.StartTimer2(lt);

			string currentTime = site.CurrentTime;
			this.dataGridView1.Rows.Add("current_time", currentTime);

			this.dataGridView1.Rows.Add("count", ++count);

			Logging.Log("Fill-InstallationsOKResponse", "End-" + bv);
			return bv;
		}

		private DateTime lastTimestamp;
#if DEBUG
		private DateTime lastTimestampDate;
#endif

		private void StartTimer2(DateTime lt)
		{
			if (this.lastTimestamp != lt && !this.timer2.Enabled)
			{
#if DEBUG
				this.dailyInit = this.lastTimestampDate != lt.Date;
				this.lastTimestampDate = lt.Date;
#endif
				this.lastTimestamp = lt;
				this.step = 1;
				Logging.Log("FormMonitor.StartTimer2", "Start, " + lt + ", " + (DateTime.Now - lt));
				this.timer2.Start();
			}
		}

		private void FormMonitor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Logging.Log("FormMonitor_FormClosing", "Begin-" + e.CloseReason + ", " + e.Cancel);

			// Warten auf den eigenen Thread ist nicht möglich
			// await Task.Delay(300); fuktioniert auch nicht, da FormMonitor_FormClosing kein 2. Mal aufgerufen wird
			this.formClosing = true;

			Logging.Log("FormMonitor_FormClosing-timer1a", this.timer1.Enabled.ToString());
			this.timer1.Stop();

			Logging.Log("FormMonitor_FormClosing-timer2a", this.timer2.Enabled.ToString());
			this.timer2.Stop();

			Logging.Log("FormMonitor_FormClosing", "End.");
		}

		private void FormMonitor_FormClosed(object sender, FormClosedEventArgs e)
		{
			Logging.Log("FormMonitor_FormClosed", "Begin-" + e.CloseReason);

			Logging.Log("FormMonitor_FormClosed-timer1a", this.timer1.Enabled.ToString());
			this.timer1.Stop();

			Logging.Log("FormMonitor_FormClosed-timer2a", this.timer2.Enabled.ToString());
			this.timer2.Stop();

			Logging.Log("FormMonitor_FormClosed", "End.");
		}

		private int step;
		private bool dailyInit;

		public bool IsBusy { get; private set; }

		private async void Timer2_Tick(object sender, EventArgs e)
		{
			if (this.IsBusy)
			{
				Logging.Log("FormMonitor.Timer2_Tick-IsBusy", this.IsBusy.ToString());
				return;
			}

			this.IsBusy = true;

			try
			{
				using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
				{
					Logging.Log("FormMonitor.Timer2_Tick-SwitchChargerOnOffAsync", "Start");
					SolarChargerData scData = await adapter.SwitchChargerOnOffAsync(Settings.Default.ModbusIpAddress, this.step, this.dailyInit);
					if (scData != null)
					{
						string message = null;
						message += "step: " + this.step + "/" + adapter.Step + ", dailyInit: " + this.dailyInit + " - ";
						message += "PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ";
						message += "Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode;
						Trace.WriteLine(message);
						Logging.Log("FormMonitor.Timer2_Tick-Fill", message);
					}

					this.step = adapter.Step;
					this.dailyInit = false;
					if (this.step == 0)
					{
						// stop timer 2
						this.timer2.Stop();
					}

					string returnValue = adapter.ReturnValue;
					if (!string.IsNullOrEmpty(returnValue))
					{
						Logging.Log("FormMonitor.Timer2_Tick-Log", returnValue);
					}
				}
			}
			catch (Exception ex)
			{
				Logging.Log("Timer2_Tick", ex.ToString());
				MessageBox.Show(ex.ToString(), "Timer2_Tick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.IsBusy = false;
			}
		}
	}
}
