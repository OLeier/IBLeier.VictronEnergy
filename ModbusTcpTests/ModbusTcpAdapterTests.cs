using IBLeier.VictronEnergy.ModbusTcp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;

namespace ModbusTcp.Tests
{
	[TestClass()]
	public class ModbusTcpAdapterTests
	{
		/// <summary>
		/// FillTest - start EasyModbusServerSimulator.exe before.
		/// </summary>
		[TestMethod()]
		public void FillTestLocalhost()
		{
			int[] fields = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 };
			SolarChargerData data = new SolarChargerData(1)
			{
				Fields = fields
			};

			using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
			{
				string returnValue = adapter.Connect("localhost", 502);
				Assert.IsTrue(string.IsNullOrEmpty(returnValue), "returnValue");

				int count = adapter.Write(data);
				Assert.AreEqual(0, count, "count");

				count = adapter.Fill(data);
				Assert.AreEqual(0, count, "count");
			}
			Assert.IsNotNull(data.Fields, "data.Fields");
			Assert.AreEqual(data.Quantity, data.Fields.Length, "data.Fields.Length");

			for (int i = 0; i < fields.Length; i++)
			{
				Assert.AreEqual(fields[i], data.Fields[i], "data.Fields[" + i + "]");
			}
		}

		/// <summary>
		/// FillSolarChargerDataTestVenus - venus device in lokal network.
		/// </summary>
		[TestMethod()]
		public void FillSolarChargerDataTestVenus()
		{
			SolarChargerData data = new SolarChargerData(239);

			using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
			{
				string returnValue = adapter.Connect("venus", 502);
				Assert.IsTrue(string.IsNullOrEmpty(returnValue), "returnValue");

				int count = adapter.Fill(data);
				Assert.AreEqual(0, count, "count");
			}
			Assert.IsNotNull(data.Fields, "data.Fields");
			Assert.AreEqual(data.Quantity, data.Fields.Length, "data.Fields.Length");
		}

		/// <summary>
		/// FillSystemDataTestVenus - venus device in lokal network.
		/// </summary>
		[TestMethod()]
		public void FillSystemDataTestVenus()
		{
			SystemData data = new SystemData(100);

			using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
			{
				string returnValue = adapter.Connect("venus", 502);
				Assert.IsTrue(string.IsNullOrEmpty(returnValue), "returnValue");

				int count = adapter.Fill(data);
				Assert.AreEqual(0, count, "count");
			}
			Assert.IsNotNull(data.Fields, "data.Fields");
			Assert.AreEqual(data.Quantity, data.Fields.Length, "data.Fields.Length");
			Assert.IsNotNull(data.Serial, "data.Serial");
			Assert.AreEqual(12, data.Serial.Length);
		}

		[TestMethod()]
		public void ChargerOnOffTestVenus()
		{
			Console.WriteLine("Console-ChargerOnOffTestVenus");
			Trace.WriteLine("Trace-ChargerOnOffTestVenus");

			SolarChargerData scData = new SolarChargerData(239);
			ChargerOnOffData coData = new ChargerOnOffData(239);

			using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
			{
				string returnValue = adapter.Connect("venus", 502);
				Assert.IsTrue(string.IsNullOrEmpty(returnValue), "returnValue");

				int count = adapter.Fill(scData);
				Assert.AreEqual(0, count, "count-1");
				Trace.Write("PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ");
				Trace.WriteLine("Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode);

				coData.Fields = new int[1];
				coData.ChargerOnOff = ChargerOnOffCode.Off;  // Off
				count = adapter.Write(coData);
				Assert.AreEqual(0, count, "count-2");

				Thread.Sleep(1000);
				Trace.WriteLine("***");

				count = adapter.Fill(scData);
				Assert.AreEqual(0, count, "count-3");
				Trace.Write("PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ");
				Trace.WriteLine("Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode);

				Thread.Sleep(1000);
				Trace.WriteLine("***");

				count = adapter.Fill(scData);
				Assert.AreEqual(0, count, "count-4");
				Trace.Write("PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ");
				Trace.WriteLine("Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode);

				coData.ChargerOnOff = ChargerOnOffCode.On;  // On
				count = adapter.Write(coData);
				Assert.AreEqual(0, count, "count-5");

				Thread.Sleep(1000);
				Trace.WriteLine("***");

				count = adapter.Fill(scData);
				Assert.AreEqual(0, count, "count-6");
				Trace.Write("PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ");
				Trace.WriteLine("Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode);

				Thread.Sleep(1000);
				Trace.WriteLine("***");

				count = adapter.Fill(scData);
				Assert.AreEqual(0, count, "count-7");
				Trace.Write("PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ");
				Trace.WriteLine("Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode);

				Thread.Sleep(1000);
				Trace.WriteLine("***");

				count = adapter.Fill(scData);
				Assert.AreEqual(0, count, "count-8");
				Trace.Write("PV: " + scData.PvVoltage + "V, " + scData.PvCurrent + "A, " + scData.PvPower + "W - ");
				Trace.WriteLine("Charger: " + scData.ChargerOnOff + ", " + scData.ChargeState + ", " + scData.MppOperationMode);
			}
		}

		[TestMethod()]
		public void AddressTest()
		{
			SolarChargerData data = new SolarChargerData(239);
			Assert.AreEqual(771, data.StartingAddress, "StartingAddress");
			Assert.AreEqual(791 - 771 + 1, data.Quantity, "Quantity");
		}
	}
}