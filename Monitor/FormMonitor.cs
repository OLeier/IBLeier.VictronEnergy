using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using IBLeier.VictronEnergy.ModbusTcp;
using IBLeier.VictronEnergy.Monitor;
using Monitor.Properties;
using Monitor.VrmApi;

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
            timer1.Interval = 5000;
#else
            timer1.Interval = Settings.Default.TimerInterval * 1000;
#endif
            timer2.Interval = Settings.Default.ModbusTimerInterval * 1000;
        }

        int count = 0;

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                Timer1_Tick(sender: null, e: null);
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
            timer1.Stop();

            Response2 installationsOKResponse;
            try
            {
                installationsOKResponse = await VrmController.GetInstallationsAsync();
                lastExceptionName = null;
            }
            catch (Exception ex)
            {
                Logging.Log("Timer1_Tick-async", ex.ToString());
                Fill(ex);

                string name = ex.GetType().Name;
                if (lastExceptionName != name)
                {
                    lastExceptionName = name;
                    MessageBox.Show(ex.ToString(), "GetInstallationsAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                installationsOKResponse = null;
            }

            if (!formClosing)
            {
                if (installationsOKResponse != null)
                {
                    try
                    {
                        double bv = Fill(installationsOKResponse);

#if DEBUG
                        Check check = null;
#else
                        Check check = Check.CheckVoltage(bv);
#endif
                        if (check != null)
                        {
                            TopMost = true;
                            MessageBox.Show(bv + " V < " + check.low + " V !!!", "Spannung zu niedrig !!!", MessageBoxButtons.OK, check.icon);
                            TopMost = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.Log("Timer1_Tick", ex.ToString());
                        MessageBox.Show(ex.ToString(), "Timer1_Tick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                timer1.Start();
            }
            return;
        }

        private void Fill(Exception exception)
        {
            Logging.Log("Fill-Exception", "Begin");
            string description = DateTime.Now.ToLongTimeString();
            string formattedValue = null;
            dataGridView1.Rows.Insert(0, description, formattedValue);

            Exception ex = exception;
            do
            {
                Logging.Log("Fill-exception", ex.ToString());
                description = ex.GetType().Name;
                formattedValue = ex.Message;
                dataGridView1.Rows.Insert(0, description, formattedValue);

                ex = ex.InnerException;
            } while (ex != null);
            Logging.Log("Fill-Exception", "End");
        }

        private double Fill(Response2 installationsOKResponse)
        {
            Logging.Log("Fill-InstallationsOKResponse", "Begin");
            double bv = 0;
            var site = installationsOKResponse.Records.First();

            dataGridView1.Rows.Clear();
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
                    dataGridView1.Rows.Add(description, formattedValue);
                }
            }

            long syscreated = site.Syscreated.Value;
            DateTime sc = DateTimeOffset.FromUnixTimeSeconds(syscreated).LocalDateTime;
            dataGridView1.Rows.Add("syscreated", sc.ToString());

            long lastTimestamp = site.Last_timestamp.Value;
            DateTime lt = DateTimeOffset.FromUnixTimeSeconds(lastTimestamp).LocalDateTime;
            dataGridView1.Rows.Add("last_timestamp", lt.ToString());
            StartTimer2(lt);

            string currentTime = site.Current_time;
            dataGridView1.Rows.Add("current_time", currentTime);

            dataGridView1.Rows.Add("count", ++count);

            Logging.Log("Fill-InstallationsOKResponse", "End-" + bv);
            return bv;
        }

        private DateTime lastTimestamp;
#if DEBUG
        private DateTime lastTimestampDate;
#endif

        private void StartTimer2(DateTime lt)
        {
            if (lastTimestamp != lt && !timer2.Enabled)
            {
#if DEBUG
                dailyInit = lastTimestampDate != lt.Date;
                lastTimestampDate = lt.Date;
#endif
                lastTimestamp = lt;
                step = 1;
                Logging.Log("FormMonitor.StartTimer2", "Start, " + lt + ", " + (DateTime.Now - lt));
                timer2.Start();
            }
        }

        private void FormMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logging.Log("FormMonitor_FormClosing", "Begin-" + e.CloseReason + ", " + e.Cancel);

            // Warten auf den eigenen Thread ist nicht möglich
            // await Task.Delay(300); fuktioniert auch nicht, da FormMonitor_FormClosing kein 2. Mal aufgerufen wird
            formClosing = true;

            Logging.Log("FormMonitor_FormClosing-timer1a", timer1.Enabled.ToString());
            timer1.Stop();

            Logging.Log("FormMonitor_FormClosing-timer2a", timer2.Enabled.ToString());
            timer2.Stop();

            Logging.Log("FormMonitor_FormClosing", "End.");
        }

        private void FormMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logging.Log("FormMonitor_FormClosed", "Begin-" + e.CloseReason);

            Logging.Log("FormMonitor_FormClosed-timer1a", timer1.Enabled.ToString());
            timer1.Stop();

            Logging.Log("FormMonitor_FormClosed-timer2a", timer2.Enabled.ToString());
            timer2.Stop();

            Logging.Log("FormMonitor_FormClosed", "End.");
        }

        private int step;
        private bool dailyInit;

        public bool IsBusy { get; private set; }

        private async void Timer2_Tick(object sender, EventArgs e)
        {
            if (IsBusy)
            {
                Logging.Log("FormMonitor.Timer2_Tick-IsBusy", IsBusy.ToString());
                return;
            }

            IsBusy = true;

            try
            {
                using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
                {
                    Logging.Log("FormMonitor.Timer2_Tick-SwitchChargerOnOffAsync", "Start");
                    SolarChargerData scData = await adapter.SwitchChargerOnOffAsync(Settings.Default.ModbusIpAddress, step, dailyInit);
                    if (scData != null)
                    {
                        string message = null;
                        message += "step: " + step + "/" + adapter.Step + ", dailyInit: " + dailyInit + " - ";
                        message += "PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ";
                        message += "Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode;
                        Trace.WriteLine(message);
                        Logging.Log("FormMonitor.Timer2_Tick-Fill", message);
                    }

                    step = adapter.Step;
                    dailyInit = false;
                    if (step == 0)
                    {
                        // stop timer 2
                        timer2.Stop();
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
                IsBusy = false;
            }
        }
    }
}
