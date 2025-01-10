namespace IBLeier.VictronEnergy.ModbusTcp
{
    /// <summary>
    /// SolarChargerData
    /// </summary>
    /// <remarks>
    /// https://www.victronenergy.com/live/ccgx:modbustcp_faq
    /// https://www.victronenergy.com/support-and-downloads/whitepapers
    /// https://github.com/victronenergy/dbus_modbustcp/blob/master/CCGX-Modbus-TCP-register-list.xlsx
    /// </remarks>
    public class SolarChargerData : IData
    {
        enum FieldIndex
        {
            BatteryVoltage,
            BatteryCurrent,
            BatteryTemperature,
            ChargerOnOff,
            ChargeState,
            PvVoltage,
            PvCurrent,
            EqualizationPending,
            EqualizationTimeRemaining,
            RelayOnTheCharger,
            Alarm,
            LowBattVoltageAlarm,
            HighBattVoltageAlarm,
            YieldToday,
            MaximumChargePowerToday,
            YieldYesterday,
            MaximumChargePowerYesterday,
            ErrorCode,
            PvPower,
            UserYield,
            MppOperationMode,
            Quantity
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="unitIdentifier">
        /// Unit-ID</br>
        /// To see a list of available devices, and their Address, go to Settings → Services → Modbus/TCP → Available services.
        /// https://www.victronenergy.com/live/ccgx:modbustcp_faq
        /// </param>
        public SolarChargerData(byte unitIdentifier)
        {
            UnitIdentifier = unitIdentifier;
            StartingAddress = 771;
            Quantity = (int)FieldIndex.Quantity;
            Fields = new int[(int)FieldIndex.Quantity];
        }

        public byte UnitIdentifier { get; }     // 239;	// com.victronenergy.solarcharger
        public int StartingAddress { get; }     // 771-791 -> 21
        public int Quantity { get; }            // (int)FieldIndex.Quantity;

        const double Scalefactor100 = 100;
        const double Scalefactor10 = 10;
        //const double Scalefactor1 = 1;

        public int[] Fields { get; set; }

        /// <summary>
        /// BatteryVoltage: V DC
        /// </summary>
        public double BatteryVoltage
        {
            get
            {
                return Fields[(int)FieldIndex.BatteryVoltage] / SolarChargerData.Scalefactor100;
            }
        }

        /// <summary>
        /// BatteryCurrent: A DC
        /// </summary>
        public double BatteryCurrent
        {
            get
            {
                return Fields[(int)FieldIndex.BatteryCurrent] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// BatteryTemperature: Degrees celsius
        /// </summary>
        public double BatteryTemperature
        {
            get
            {
                return Fields[(int)FieldIndex.BatteryTemperature] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// ChargerOnOff: 1=On;4=Off
        /// </summary>
        public ChargerOnOffCode ChargerOnOff
        {
            get
            {
                return (ChargerOnOffCode)Fields[(int)FieldIndex.ChargerOnOff];
            }
        }

        /// <summary>
        /// ChargeState: 0=Off;2=Fault;3=Bulk;4=Absorption;5=Float;6=Storage;7=Equalize;11=Other (Hub-1);252=External control
        /// 245=Aufwachen: 0 - 245 - 3
        /// </summary>
        public ChargeStateCode ChargeState
        {
            get
            {
                return (ChargeStateCode)Fields[(int)FieldIndex.ChargeState];
            }
        }

        /// <summary>
        /// PvVoltage: V DC
        /// </summary>
        public double PvVoltage
        {
            get
            {
                return Fields[(int)FieldIndex.PvVoltage] / SolarChargerData.Scalefactor100;
            }
        }

        /// <summary>
        /// PvCurrent: A DC
        /// </summary>
        public double PvCurrent
        {
            get
            {
                return Fields[(int)FieldIndex.PvCurrent] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// EqualizationPending: 0=No;1=Yes;2=Error;3=Unavailable- Unknown
        /// </summary>
        public int EqualizationPending
        {
            get
            {
                return Fields[(int)FieldIndex.EqualizationPending];
            }
        }

        /// <summary>
        /// EqualizationTimeRemaining: seconds
        /// </summary>
        public double EqualizationTimeRemaining
        {
            get
            {
                return Fields[(int)FieldIndex.EqualizationTimeRemaining] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// RelayOnTheCharger: 0=Open;1=Closed
        /// </summary>
        public int RelayOnTheCharger
        {
            get
            {
                return Fields[(int)FieldIndex.RelayOnTheCharger];
            }
        }

        /// <summary>
        /// Alarm: 0=No alarm;2=Alarm; Deprecated. Value is always 0
        /// </summary>
        public int Alarm
        {
            get
            {
                return Fields[(int)FieldIndex.Alarm];
            }
        }

        /// <summary>
        /// LowBattVoltageAlarm: 0=No alarm;2=Alarm
        /// </summary>
        public int LowBattVoltageAlarm
        {
            get
            {
                return Fields[(int)FieldIndex.LowBattVoltageAlarm];
            }
        }

        /// <summary>
        /// HighBattVoltageAlarm: 0=No alarm;2=Alarm
        /// </summary>
        public int HighBattVoltageAlarm
        {
            get
            {
                return Fields[(int)FieldIndex.HighBattVoltageAlarm];
            }
        }

        /// <summary>
        /// YieldToday: kWh, Today's yield
        /// </summary>
        public double YieldToday
        {
            get
            {
                return Fields[(int)FieldIndex.YieldToday] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// MaximumChargePowerToday: W, Today's maximum power
        /// </summary>
        public int MaximumChargePowerToday
        {
            get
            {
                return Fields[(int)FieldIndex.MaximumChargePowerToday];
            }
        }

        /// <summary>
        /// YieldYesterday: kWh, Yesterday's yield
        /// </summary>
        public double YieldYesterday
        {
            get
            {
                return Fields[(int)FieldIndex.YieldYesterday] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// MaximumChargePowerYesterday: W, Yesterday's maximum power
        /// </summary>
        public int MaximumChargePowerYesterday
        {
            get
            {
                return Fields[(int)FieldIndex.MaximumChargePowerYesterday];
            }
        }

        /// <summary>
        /// ErrorCode:
        /// 0=No error;
        /// 1=Battery temperature too high;
        /// 2=Battery voltage too high;
        /// 3=Battery temperature sensor miswired (+);
        /// 4=Battery temperature sensor miswired (-);
        /// 5=Battery temperature sensor disconnected;
        /// 6=Battery voltage sense miswired (+);
        /// 7=Battery voltage sense miswired (-);
        /// 8=Battery voltage sense disconnected;
        /// 9=Battery voltage wire losses too high;
        /// 17=Charger temperature too high;
        /// 18=Charger over-current;
        /// 19=Charger current polarity reversed;
        /// 20=Bulk time limit reached;
        /// 22=Charger temperature sensor miswired;
        /// 23=Charger temperature sensor disconnected;
        /// 34=Input current too high
        /// </summary>
        public int ErrorCode
        {
            get
            {
                return Fields[(int)FieldIndex.ErrorCode];
            }
        }

        /// <summary>
        /// PvPower: W
        /// </summary>
        public double PvPower
        {
            get
            {
                return Fields[(int)FieldIndex.PvPower] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// UserYield: kWh, Energy generated by the solarcharger since last user reset
        /// </summary>
        public double UserYield
        {
            get
            {
                return Fields[(int)FieldIndex.UserYield] / SolarChargerData.Scalefactor10;
            }
        }

        /// <summary>
        /// MppOperationMode: 0=Off;1=Voltage/current limited;2=MPPT active;255=Not available
        /// </summary>
        public MppOperationModeCode MppOperationMode
        {
            get
            {
                return (MppOperationModeCode)Fields[(int)FieldIndex.MppOperationMode];
            }
        }

        public double DifferenceVoltage
        {
            get { return PvVoltage - BatteryVoltage; }
        }
    }
}
