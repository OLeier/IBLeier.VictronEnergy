using IBLeier.VictronEnergy.ModbusTcp;
using System;
using System.Diagnostics;

namespace MonitoringApp.ViewModels
{
	public class SolarViewModel : BaseViewModel
	{
		private const byte unitIdentifier = 239;
		private readonly SolarChargerData solarChargerData = new SolarChargerData(SolarViewModel.unitIdentifier);
		private const string modbusIpAddress = "venus";

		public SolarViewModel()
		{
			this.Title = "Solar Monitor";

			this.BatteryVoltage = 1;
			this.BatteryCurrent = 2;
			this.BatteryPower = this.BatteryVoltage * this.BatteryCurrent;

			this.AppearingAsync();
			/*
			Device.StartTimer(TimeSpan.FromSeconds(2), () =>
			{
				this.ExecuteLoadItemsCommand();
				return true;
			});
			*/
		}

		public void AppearingAsync()
		{
			IsBusy = true;

			try
			{
				SolarChargerData scData;
				using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
				{
					scData = adapter.SwitchChargerOnOff(SolarViewModel.modbusIpAddress, step: 0, dailyInit: false);
					if (scData != null)
					{
						this.BatteryVoltage = scData.BatteryVoltage;
						this.BatteryCurrent = scData.BatteryCurrent;
						this.BatteryPower = this.BatteryVoltage * this.BatteryCurrent;
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}

		public double BatteryVoltage
		{
			get => batteryVoltage;
			set => SetProperty(ref batteryVoltage, value);
		}
		private double batteryVoltage;

		public double BatteryCurrent
		{
			get => batteryCurrent;
			set => SetProperty(ref batteryCurrent, value);
		}
		private double batteryCurrent;

		public double BatteryPower
		{
			get => batteryPower;
			set => SetProperty(ref batteryPower, value);
		}
		private double batteryPower;
	}
}
