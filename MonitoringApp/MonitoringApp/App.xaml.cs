using System.Diagnostics;
using MonitoringApp.Services;

namespace MonitoringApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //MainPage = new AppShell();
            //Windows[0].Page = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            Debug.WriteLine("*** " + Task.CurrentId + ": App");

            //return base.CreateWindow(activationState);
            return new Window(new AppShell());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
