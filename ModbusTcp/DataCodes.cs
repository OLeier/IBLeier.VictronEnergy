namespace IBLeier.VictronEnergy.ModbusTcp
{
    public enum ChargerOnOffCode
    {
        On = 1,
        Off = 4
    }

    public enum ChargeStateCode
    {
        Off = 0,
        Fault = 2,
        Bulk = 3,
        Absorption = 4,
        Float = 5,
        Storage = 6,
        Equalize = 7,
        /// <summary>Other (Hub-1)</summary>
        Other = 11,
        /// <summary>External control</summary>
        External = 252,
        /// <summary>Aufwachen: 0 - 245 - 3</summary>
        WakeUp = 245
    }

    public enum MppOperationModeCode
    {
        Off = 0,
        /// <summary>Voltage/current limited</summary>
        Limited = 1,
        /// <summary>MPPT active</summary>
        Active = 2,
        /// <summary>Not available</summary>
        NotAvailable = 255
    }
}
