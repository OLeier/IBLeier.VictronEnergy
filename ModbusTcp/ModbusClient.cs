using System.Net.Sockets;
using System.Threading.Tasks;
using NModbus;

namespace IBLeier.VictronEnergy.ModbusTcp
{
    /// <summary>
    /// ModbusClient
    /// </summary>
    /// <remarks>
    /// Used MetaData from Assembly EasyModbus, Version=5.6.0.0, Culture=neutral, PublicKeyToken=null
    /// http://easymodbustcp.net/en/licenseinfo
    /// https://sourceforge.net/projects/easymodbustcp/
    /// https://github.com/rossmann-engineering/EasyModbusTCP.NET
    /// EasyModbus is not for .NET Standard, so using NModbus
    /// https://github.com/NModbus/NModbus
    /// </remarks>
    internal class ModbusClient
    {
        TcpClient masterTcpClient;
        IModbusMaster master;

        //
        // Zusammenfassung:
        //     Parameterless constructor
        public ModbusClient()
        {
        }

        //
        // Zusammenfassung:
        //     Establish connection to Master device in case of Modbus TCP.
        public void Connect(string ipAddress, int port)
        {
            // create the master
            masterTcpClient = new TcpClient();
            Task task = masterTcpClient.ConnectAsync(ipAddress, port);
            task.Wait();

            var factory = new ModbusFactory();
            master = factory.CreateMaster(masterTcpClient);
        }

        //
        // Zusammenfassung:
        //     Close connection to Master Device.
        public void Disconnect()
        {
            if (masterTcpClient != null)
            {
                masterTcpClient.Dispose();
                masterTcpClient = null;
            }
            if (master != null)
            {
                master.Dispose();
                master = null;
            }
        }

        //
        // Zusammenfassung:
        //     Returns "TRUE" if Client is connected to Server and "FALSE" if not. In case of
        //     Modbus RTU returns if COM-Port is opened
        public bool Connected
        {
            get
            {
                return (masterTcpClient != null) && masterTcpClient.Connected;
            }
        }

        //
        // Zusammenfassung:
        //     Gets or Sets the Unit identifier in case of serial connection (Default = 0)
        public byte UnitIdentifier { get; set; }

        //
        // Zusammenfassung:
        //     Write multiple coils to Master device (FC15).
        //
        // Parameter:
        //   startingAddress:
        //     First coil to be written
        //
        //   values:
        //     Coil Values to be written
        public void WriteMultipleCoils(int startingAddress, bool[] values)
        {
            throw new System.NotImplementedException();
        }

        //
        // Zusammenfassung:
        //     Read Coils from Server device (FC1).
        //
        // Parameter:
        //   startingAddress:
        //     First coil to read
        //
        //   quantity:
        //     Numer of coils to read
        //
        // Rückgabewerte:
        //     Boolean Array which contains the coils
        public bool[] ReadCoils(int startingAddress, int quantity)
        {
            throw new System.NotImplementedException();
        }

        //
        // Zusammenfassung:
        //     Read Holding Registers from Master device (FC3).
        //
        // Parameter:
        //   startingAddress:
        //     First holding register to be read
        //
        //   quantity:
        //     Number of holding registers to be read
        //
        // Rückgabewerte:
        //     Int Array which contains the holding registers
        public int[] ReadHoldingRegisters(int startingAddress, int quantity)
        {
            ushort[] result = master.ReadHoldingRegisters(UnitIdentifier, (ushort)startingAddress, (ushort)quantity);
            int[] retval = new int[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                retval[i] = (short)result[i];   // convert first to signed, then to int
            }
            return retval;
        }

        //
        // Zusammenfassung:
        //     Write multiple registers to Master device (FC16).
        //
        // Parameter:
        //   startingAddress:
        //     First register to be written
        //
        //   values:
        //     register Values to be written
        public void WriteMultipleRegisters(int startingAddress, int[] values)
        {
            ushort[] data = new ushort[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                data[i] = (ushort)values[i];
            }
            master.WriteMultipleRegisters(UnitIdentifier, (ushort)startingAddress, data);
        }
    }
}