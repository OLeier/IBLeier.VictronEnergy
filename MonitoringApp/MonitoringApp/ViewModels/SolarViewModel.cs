using System.Diagnostics;
using System.Globalization;
using IBLeier.VictronEnergy.ModbusTcp;

namespace MonitoringApp.ViewModels
{
    public partial class SolarViewModel : BaseViewModel
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

            // TODO Xamarin.Forms.Device.StartTimer wird nicht mehr unterstützt. Verwenden Sie stattdessen Microsoft.Maui.Dispatching.DispatcherExtensions.StartTimer. Weitere Informationen finden Sie unter: https://learn.microsoft.com/en-us/dotnet/maui/migration/forms-projects#device-changes
            // https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.dispatching.dispatcherextensions.starttimer?view=net-maui-9.0
            IDispatcher dispatcher = Application.Current.Dispatcher;
            dispatcher.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                Debug.WriteLine("*** " + Task.CurrentId + ": loadChargerDataTask: " + this.loadChargerDataTask?.Status);
                if ((this.loadChargerDataTask == null) || (this.loadChargerDataTask.Status == TaskStatus.RanToCompletion))
                {
                    this.loadChargerDataTask = this.LoadChargerDataAsync();
                }
                return true;
            });

            // Display the name of the current thread culture.
            Debug.WriteLine("*** CurrentCulture is " + CultureInfo.CurrentCulture.Name);
            // Display the name of the current UI culture.
            Debug.WriteLine("*** CurrentUICulture is " + CultureInfo.CurrentUICulture.Name);
            // GetUserDefaultUILanguage win32
            Debug.WriteLine("*** DefaultThreadCurrentUICulture is " + CultureInfo.DefaultThreadCurrentUICulture?.Name);
        }

        public async Task LoadChargerDataAsync()
        {
            if (IsBusy)
            {
                Debug.WriteLine("*** LoadChargerDataAsync.IsBusy: " + IsBusy);
                return;
            }

            IsBusy = true;

            try
            {
                using var adapter = new ModbusTcpAdapter();
                {
                    Debug.WriteLine("*** " + Task.CurrentId + ": SwitchChargerOnOffAsync-Start");
                    SolarChargerData scData = await adapter.SwitchChargerOnOffAsync(SolarViewModel.modbusIpAddress, step: 0, dailyInit: false);
                    Debug.WriteLine("*** " + Task.CurrentId + ": SwitchChargerOnOffAsync-" + scData);
                    if (scData != null)
                    {
                        this.MppOperationMode = scData.MppOperationMode;
                        this.ChargeState = scData.ChargeState;

                        this.PvVoltage = scData.PvVoltage;
                        this.PvCurrent = scData.PvCurrent;
                        this.PvPowerSoc = scData.PvPower;
                        this.PvPower = this.PvVoltage * this.PvCurrent;

                        this.BatteryVoltage = scData.BatteryVoltage;
                        this.BatteryCurrent = scData.BatteryCurrent;
                        this.BatteryPower = this.BatteryVoltage * this.BatteryCurrent;

                        this.LoadPower = this.PvPower - this.BatteryPower;
                        this.LoadCurrent = this.LoadPower / this.BatteryVoltage;
                    }

                    this.Time = DateTime.Now;
                    this.Message = adapter.ReturnValue;
                }
            }
            catch (Exception ex)
            {
                this.Time = DateTime.Now;
                this.Message = ex.Message;
                Debug.WriteLine("*** " + Task.CurrentId + ": " + ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public MppOperationModeCode MppOperationMode
        {
            get => mppOperationMode;
            set => SetProperty(ref mppOperationMode, value);
        }
        private MppOperationModeCode mppOperationMode;

        public ChargeStateCode ChargeState
        {
            get => chargeState;
            set => SetProperty(ref chargeState, value);
        }
        private ChargeStateCode chargeState;

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

        public double LoadCurrent
        {
            get => loadCurrent;
            set => SetProperty(ref loadCurrent, value);
        }
        private double loadCurrent;

        public double LoadPower
        {
            get => loadPower;
            set => SetProperty(ref loadPower, value);
        }
        private double loadPower;

        public DateTime Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }
        private DateTime time;

        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }
        private string message;
    }
}
