using System.Windows.Forms;
using Monitor.Properties;

namespace IBLeier.VictronEnergy.Monitor
{
    public class Check
    {
        static readonly Check[] checks;
        //= {
        //	new Check(24.8, 24.95, MessageBoxIcon.Warning),
        //	new Check(24.5, 24.65, MessageBoxIcon.Warning),
        //	new Check(24.2, 24.35, MessageBoxIcon.Error)
        //};

        static Check()
        {
            Check.checks = new Check[4];
            double low = Settings.Default.LowVoltage;
            double high = low + Settings.Default.VoltageStep / 2;
            Check.checks[3] = new Check(low, high, MessageBoxIcon.Error);
            low += Settings.Default.VoltageStep;
            high += Settings.Default.VoltageStep;
            Check.checks[2] = new Check(low, high, MessageBoxIcon.Warning);
            low += Settings.Default.VoltageStep;
            high += Settings.Default.VoltageStep;
            Check.checks[1] = new Check(low, high, MessageBoxIcon.Warning);
            Check.checks[0] = new Check(26.0, 26.2, MessageBoxIcon.Warning);
        }

        public readonly double low;
        readonly double high;
        public readonly MessageBoxIcon icon;
        private bool alert;

        private Check(double lowValue, double highValue, MessageBoxIcon messageBoxIcon)
        {
            low = lowValue;
            high = highValue;
            icon = messageBoxIcon;
            alert = false;
        }

        public static Check CheckVoltage(double bv)
        {
            Check retval = null;
            foreach (Check check in Check.checks)
            {
                if (check.CheckVoltageIntern(bv))
                {
                    retval = check;
                }
            }

            return retval;
        }

        private bool CheckVoltageIntern(double bv)
        {
            bool retValue = false;
            if (bv < low)
            {
                if (!alert)
                {
                    retValue = true;
                    alert = true;
                }
            }
            else if (bv > high)
            {
                alert = false;
            }
            return retValue;
        }
    }
}
