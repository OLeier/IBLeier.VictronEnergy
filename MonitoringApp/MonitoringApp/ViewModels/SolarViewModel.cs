using IBLeier.VictronEnergy.ModbusTcp;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonitoringApp.ViewModels
{
	public class SolarViewModel : BaseViewModel
	{
		//private const byte unitIdentifier = 239;
		//private readonly SolarChargerData solarChargerData = new SolarChargerData(SolarViewModel.unitIdentifier);
		private const string modbusIpAddress = "venus";

		private Task loadChargerDataTask;

		public SolarViewModel()
		{
			Debug.WriteLine("*** " + Task.CurrentId + ": SolarViewModel");

			this.Title = "Solar Monitor";

			this.BatteryVoltage = 1;
			this.BatteryCurrent = 2;
			this.BatteryPower = this.BatteryVoltage * this.BatteryCurrent;

			Device.StartTimer(TimeSpan.FromSeconds(5), () =>
			{
				Debug.WriteLine("*** " + Task.CurrentId + ": loadChargerDataTask: " + this.loadChargerDataTask?.Status);
				if ((this.loadChargerDataTask == null) || (this.loadChargerDataTask.Status == TaskStatus.RanToCompletion))
				{
					this.loadChargerDataTask = this.LoadChargerDataAsync();
				}
				return true;
			});
		}

		public async Task LoadChargerDataAsync()
		{
			IsBusy = true;

			try
			{
				using (ModbusTcpAdapter adapter = new ModbusTcpAdapter())
				{
					Debug.WriteLine("*** " + Task.CurrentId + ": SwitchChargerOnOffAsync-Start");
					var scData = await adapter.SwitchChargerOnOffAsync(SolarViewModel.modbusIpAddress, step: 0, dailyInit: false);
					Debug.WriteLine("*** " + Task.CurrentId + ": SwitchChargerOnOffAsync-" + scData);
					if (scData != null)
					{
						this.BatteryVoltage = scData.BatteryVoltage;
						this.BatteryCurrent = scData.BatteryCurrent;
						this.BatteryPower = this.BatteryVoltage * this.BatteryCurrent;
						this.PvVoltage = scData.PvVoltage;
						this.PvCurrent = scData.PvCurrent;
						this.PvPowerSoc = scData.PvPower;
						this.PvPower = this.PvVoltage * this.PvCurrent;
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("*** " + Task.CurrentId + ": " + ex);
			}
			finally
			{
				IsBusy = false;
			}
		}

		public double PvVoltage
		{
			get => pvVoltage;
			set => SetProperty(ref pvVoltage, value);
		}
		private double pvVoltage;

		public double PvCurrent
		{
			get => pvCurrent;
			set => SetProperty(ref pvCurrent, value);
		}
		private double pvCurrent;

		public double PvPower
		{
			get => pvPower;
			set => SetProperty(ref pvPower, value);
		}
		private double pvPower;

		public double PvPowerSoc
		{
			get => pvPowerSoc;
			set => SetProperty(ref pvPowerSoc, value);
		}
		private double pvPowerSoc;

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
