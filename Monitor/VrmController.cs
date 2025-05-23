using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Rest;
using Monitor;
using Monitor.Properties;
using Monitor.VrmApi;

namespace IBLeier.VictronEnergy.Monitor
{
    public class VrmController
    {
        public static Task<Response2> GetInstallationsAsync()
        {
            return Task.Run(() =>
            {
                return VrmController.GetInstallations();
            });
        }

        public static Response2 GetInstallations()
        {
            Logging.Log("VrmController_GetInstallations", "Begin");
            HttpClient httpClient = new HttpClient();
            //ServiceClientCredentials credentials = new BasicAuthenticationCredentials();

            var client = new Client(httpClient);
            {
                ServiceClientTracing.IsEnabled = false;
                ServiceClientTracing.AddTracingInterceptor(new DebugTracer());

                Credential credential = new Credential()
                {
                    Username = Settings.Default.Username,
                    Password = Settings.Default.Password
                };
                Response loginOKResponse = client.LoginAsync(credential).Result;
                //Console.WriteLine("Login: " + loginOKResponse.Token);

                string xAuthorization = "Bearer " + loginOKResponse.Token;

                Response2 installationsOKResponse = client.InstallationsAsync(xAuthorization, loginOKResponse.IdUser, extended: 1).Result;
                //Console.WriteLine("Installations: " + installationsOKResponse.Success + ", " + installationsOKResponse.Records.Count);

                //var site = installationsOKResponse.Records.First();

                ////var extended = site["extended"] as JArray;
                ////foreach (var item in extended)
                ////{
                ////	Console.WriteLine(item["description"] + ": " + item["formattedValue"]);
                ////}

                //int idSite = Convert.ToInt32(site["idSite"]);   // long
                //SystemOverviewOKResponse systemOverviewOKResponse = client.SystemOverview(xAuthorization, idSite);
                //Console.WriteLine("systemOverviewOKResponse: " + systemOverviewOKResponse.Success.Value + ", " + systemOverviewOKResponse.Records.Devices.Count);

                //var device = systemOverviewOKResponse.Records.Devices.First(d => (string)d["name"] == "Solar Charger");
                //int instance = Convert.ToInt32(device["instance"]);   // long
                //SolarChargerSummaryOKResponse solarChargerSummaryOKResponse = client.SolarChargerSummary(xAuthorization, idSite, instance);
                //Console.WriteLine("solarChargerSummaryOKResponse: " + solarChargerSummaryOKResponse.Success.Value + ", " + solarChargerSummaryOKResponse.Records.Meta.Count);

                client.LogoutAsync(xAuthorization).Wait();
                //Console.WriteLine("Logout");

                Logging.Log("VrmController_GetInstallations", "End");
                return installationsOKResponse;
            }
        }
    }
}
