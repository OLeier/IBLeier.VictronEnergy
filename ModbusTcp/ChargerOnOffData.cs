namespace IBLeier.VictronEnergy.ModbusTcp
{
    public class ChargerOnOffData : IData
    {
        enum FieldIndex
        {
            ChargerOnOff,
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
        public ChargerOnOffData(byte unitIdentifier)
        {
            UnitIdentifier = unitIdentifier;
            StartingAddress = 774;
            Quantity = (int)FieldIndex.Quantity;
            Fields = new int[(int)FieldIndex.Quantity];
        }

        public byte UnitIdentifier { get; }     // 239;	// com.victronenergy.solarcharger
        public int StartingAddress { get; }     // 771-791
        public int Quantity { get; }            // (int)FieldIndex.Quantity;

        public int[] Fields { get; set; }

        /// <summary>
        /// ChargerOnOff: 1=On;4=Off
        /// </summary>
        public ChargerOnOffCode ChargerOnOff
        {
            get
            {
                return (ChargerOnOffCode)Fields[(int)FieldIndex.ChargerOnOff];
            }
            set
            {
                Fields[(int)FieldIndex.ChargerOnOff] = (int)value;
            }
        }
    }
}
