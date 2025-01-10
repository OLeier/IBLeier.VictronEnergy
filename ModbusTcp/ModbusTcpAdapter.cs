using System;
using System.Threading.Tasks;

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
    /// ersetzt durch NModbus, siehe <see cref="ModbusClient"/>.
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
            if (modbusClient.Connected)
            {
                modbusClient.Disconnect();
            }

            string returnValue = "*** Connect(" + ipAddress + ", " + port + ") *** ";
            try
            {
                modbusClient.Connect(ipAddress, port);
                returnValue = null;
            }
            catch (AggregateException ae)
            {
                foreach (Exception ie in ae.InnerExceptions)
                {
                    Console.WriteLine(ie);
                    returnValue += ie.Message + " *** ";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                returnValue += ex.Message;
            }
            return returnValue;
        }

        public int Write(IData data)
        {
            int returnValue = 0;

            try
            {
                modbusClient.UnitIdentifier = data.UnitIdentifier;
                modbusClient.WriteMultipleRegisters(data.StartingAddress, data.Fields);

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
                // com.victronenergy.system			Unit-ID: 100	800-866
                // com.victronenergy.solarcharger	Unit-ID: 239	771-790	0x303 + 3700-3723
                //ModbusClient modbusClient = new ModbusClient("localhost", 502);		//Ip-Address and Port of Modbus-TCP-Server
                //modbusClient.Connect();												//Connect to Server
                modbusClient.UnitIdentifier = data.UnitIdentifier;
                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(data.StartingAddress, data.Quantity);
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
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                    if (modbusClient.Connected)
                    {
                        modbusClient.Disconnect();
                    }
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.

                disposedValue = true;
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
            Dispose(true);
            // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            GC.SuppressFinalize(this);
        }
        #endregion

        public int Step { get; set; }

        public string ReturnValue { get; private set; }

        public Task<SolarChargerData> SwitchChargerOnOffAsync(string modbusIpAddress, int step, bool dailyInit)
        {
            return Task.Run(() =>
            {
                return SwitchChargerOnOff(modbusIpAddress, step, dailyInit);
            });
        }

        public SolarChargerData SwitchChargerOnOff(string modbusIpAddress, int step, bool dailyInit)
        {
            Step = step;

            SolarChargerData scData = new SolarChargerData(239);
            ChargerOnOffData coData = new ChargerOnOffData(239);

            ReturnValue = Connect(modbusIpAddress, 502);
            if (!string.IsNullOrEmpty(ReturnValue))
            {
                Step = 0;
                return null;
            }

            int count = Fill(scData);
            if (count < 0)
            {
                Step = 0;
                return null;
            }

            // 1. Charger is On and working
            if (Step == 1 && scData.ChargerOnOff == ChargerOnOffCode.On)
            {
                if (scData.ChargeState != ChargeStateCode.Off &&
                    (scData.PvPower < 0.5 || dailyInit ||
                    (scData.PvCurrent < 0.5 && (scData.PvVoltage > 40 || scData.DifferenceVoltage < 3.5) && scData.PvPower < 1.5)
                    ))
                {
                    // Switch Off
                    coData.ChargerOnOff = ChargerOnOffCode.Off;
                    count = Write(coData);
                    ReturnValue = "Switch Off: " + count;
                    Step = 2;
                }
                else
                {
                    // stop timer 2
                    ReturnValue = "Stop1";
                    Step = 0;
                }
            }

            // 2. Charger is Off /* and not working */
            if (Step != 3 && scData.ChargerOnOff == ChargerOnOffCode.Off /* && scData.ChargeState == ChargeStateCode.Off */)
            {
                // Switch On
                coData.ChargerOnOff = ChargerOnOffCode.On;
                count = Write(coData);
                ReturnValue = "Switch On: " + count;
                Step = 3;
            }

            // 3. Charger is On. working isn't necessary
            if (Step == 3 && scData.ChargerOnOff == ChargerOnOffCode.On)
            {
                // stop timer 2
                ReturnValue = "Stop2";
                Step = 0;
            }

            return scData;
        }
    }
}
