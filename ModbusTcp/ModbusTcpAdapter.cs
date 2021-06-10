using System;

namespace IBLeier.VictronEnergy.ModbusTcp
{
	/// <summary>
	/// ModbusTcpAdapter
	/// </summary>
	/// <remarks>
	/// Used EasyModbus.dll from
	/// http://easymodbustcp.net/en/licenseinfo
	/// https://sourceforge.net/projects/easymodbustcp/
	/// https://github.com/rossmann-engineering/EasyModbusTCP.NET
	/// </remarks>
	public class ModbusTcpAdapter : IDisposable
	{
		readonly ModbusClient modbusClient = new ModbusClient();

		/// <summary>
		/// CodeSample from http://easymodbustcp.net/codesampleseasymodbustcp-net.
		/// </summary>
		public static void CodeSample()
		{
			ModbusClient modbusClient = new ModbusClient();   //Ip-Address and Port of Modbus-TCP-Server
			modbusClient.Connect("190.201.100.100", 502);                                                 //Connect to Server
			modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });  //Write Coils starting with Address 5
			bool[] readCoils = modbusClient.ReadCoils(9, 10);                       //Read 10 Coils from Server, starting with address 10
			int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);  //Read 10 Holding Registers from Server, starting with Address 1

			// Console Output
			for (int i = 0; i < readCoils.Length; i++)
				Console.WriteLine("Value of Coil " + (9 + i + 1) + " " + readCoils[i].ToString());

			for (int i = 0; i < readHoldingRegisters.Length; i++)
				Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
			modbusClient.Disconnect();                                              //Disconnect from Server
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public string Connect(string ipAddress, int port)
		{
			if (this.modbusClient.Connected)
			{
				this.modbusClient.Disconnect();
			}

			string returnValue = null;
			try
			{
				this.modbusClient.Connect(ipAddress, port);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				returnValue = ex.Message;
			}
			return returnValue;
		}

		public int Write(IData data)
		{
			int returnValue = 0;

			try
			{
				this.modbusClient.UnitIdentifier = data.UnitIdentifier;
				this.modbusClient.WriteMultipleRegisters(data.StartingAddress, data.Fields);

				// Console Output
				//for (int i = 0; i < data.Fields.Length; i++)
				//	Console.WriteLine("Value of WriteRegisters " + (i + 1) + " " + data.Fields[i].ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				returnValue = -1;
			}
			return returnValue;
		}

		public int Fill(IData data)
		{
			int returnValue = 0;

			try
			{
				// localhost, venus
				// com.victronenergy.system			Unit-ID: 100
				// com.victronenergy.solarcharger	Unit-ID: 239	771-790	0x303
				//ModbusClient modbusClient = new ModbusClient("localhost", 502);		//Ip-Address and Port of Modbus-TCP-Server
				//modbusClient.Connect();												//Connect to Server
				this.modbusClient.UnitIdentifier = data.UnitIdentifier;
				int[] readHoldingRegisters = this.modbusClient.ReadHoldingRegisters(data.StartingAddress, data.Quantity);
				data.Fields = readHoldingRegisters;

				// Console Output
				//for (int i = 0; i < readHoldingRegisters.Length; i++)
				//	Console.WriteLine("Value of HoldingRegisters " + (i + 1) + " " + readHoldingRegisters[i].ToString());
				//modbusClient.Disconnect();											//Disconnect from Server
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				returnValue = -1;
			}
			return returnValue;
		}

		#region IDisposable Support
		private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
					// TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
					if (this.modbusClient.Connected)
					{
						this.modbusClient.Disconnect();
					}
				}

				// TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
				// TODO: große Felder auf Null setzen.

				this.disposedValue = true;
			}
		}

		// TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
		// ~ModbusTcpAdapter() {
		//   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
		//   Dispose(false);
		// }

		// Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
		public void Dispose()
		{
			// Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
			this.Dispose(true);
			// TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
