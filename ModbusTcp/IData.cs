namespace IBLeier.VictronEnergy.ModbusTcp
{
	public interface IData
	{
		byte UnitIdentifier { get; }        // 239;	// com.victronenergy.solarcharger

		int StartingAddress { get; }  // 771-791

		int Quantity { get; }

		int[] Fields { get; set; }
	}
}
