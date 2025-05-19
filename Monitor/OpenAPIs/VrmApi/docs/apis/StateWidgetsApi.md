# Org.OpenAPITools.Api.StateWidgetsApi

All URIs are relative to *https://vrmapi.victronenergy.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InstallationsIdSiteWidgetsBatteryExternalRelayStateCommand**](StateWidgetsApi.md#installationsidsitewidgetsbatteryexternalrelaystatecommand) | **GET** /installations/{idSite}/widgets/BatteryExternalRelayState | Battery external relay state graph data |
| [**InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarms**](StateWidgetsApi.md#installationsidsitewidgetsbatterymonitorwarningsandalarms) | **GET** /installations/{idSite}/widgets/BatteryMonitorWarningsAndAlarms | Battery monitor warnings and alarms graph data |
| [**InstallationsIdSiteWidgetsBatteryRelayState**](StateWidgetsApi.md#installationsidsitewidgetsbatteryrelaystate) | **GET** /installations/{idSite}/widgets/BatteryRelayState | Battery relay state graph data |
| [**InstallationsIdSiteWidgetsChargerRelayState**](StateWidgetsApi.md#installationsidsitewidgetschargerrelaystate) | **GET** /installations/{idSite}/widgets/ChargerRelayState | Charger relay state graph data |
| [**InstallationsIdSiteWidgetsChargerState**](StateWidgetsApi.md#installationsidsitewidgetschargerstate) | **GET** /installations/{idSite}/widgets/ChargerState | Charger state graph data |
| [**InstallationsIdSiteWidgetsEssBatteryLifeState**](StateWidgetsApi.md#installationsidsitewidgetsessbatterylifestate) | **GET** /installations/{idSite}/widgets/EssBatteryLifeState | ESS battery life state graph data |
| [**InstallationsIdSiteWidgetsFuelCellState**](StateWidgetsApi.md#installationsidsitewidgetsfuelcellstate) | **GET** /installations/{idSite}/widgets/FuelCellState | Fuel cell state graph data |
| [**InstallationsIdSiteWidgetsGatewayRelayState**](StateWidgetsApi.md#installationsidsitewidgetsgatewayrelaystate) | **GET** /installations/{idSite}/widgets/GatewayRelayState | Gateway relay state graph data |
| [**InstallationsIdSiteWidgetsGatewayRelayTwoState**](StateWidgetsApi.md#installationsidsitewidgetsgatewayrelaytwostate) | **GET** /installations/{idSite}/widgets/GatewayRelayTwoState | Gateway relay two state graph data |
| [**InstallationsIdSiteWidgetsGeneratorState**](StateWidgetsApi.md#installationsidsitewidgetsgeneratorstate) | **GET** /installations/{idSite}/widgets/GeneratorState | Generator state graph data |
| [**InstallationsIdSiteWidgetsInputState**](StateWidgetsApi.md#installationsidsitewidgetsinputstate) | **GET** /installations/{idSite}/widgets/InputState | Input state graph data |
| [**InstallationsIdSiteWidgetsInverterChargerState**](StateWidgetsApi.md#installationsidsitewidgetsinverterchargerstate) | **GET** /installations/{idSite}/widgets/InverterChargerState | Inverter charger state graph data |
| [**InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarms**](StateWidgetsApi.md#installationsidsitewidgetsinverterchargerwarningsandalarms) | **GET** /installations/{idSite}/widgets/InverterChargerWarningsAndAlarms | Inverter charger warnings and alarms graph data |
| [**InstallationsIdSiteWidgetsInverterState**](StateWidgetsApi.md#installationsidsitewidgetsinverterstate) | **GET** /installations/{idSite}/widgets/InverterState | Inverter state graph data |
| [**InstallationsIdSiteWidgetsMPPTState**](StateWidgetsApi.md#installationsidsitewidgetsmpptstate) | **GET** /installations/{idSite}/widgets/MPPTState | MPPT state graph data |
| [**InstallationsIdSiteWidgetsSolarChargerRelayState**](StateWidgetsApi.md#installationsidsitewidgetssolarchargerrelaystate) | **GET** /installations/{idSite}/widgets/SolarChargerRelayState | Solar charger relay state graph data |
| [**InstallationsIdSiteWidgetsVeBusState**](StateWidgetsApi.md#installationsidsitewidgetsvebusstate) | **GET** /installations/{idSite}/widgets/VeBusState | VE Bus state graph data |
| [**InstallationsIdSiteWidgetsVeBusWarningsAndAlarms**](StateWidgetsApi.md#installationsidsitewidgetsvebuswarningsandalarms) | **GET** /installations/{idSite}/widgets/VeBusWarningsAndAlarms | VE Bus warnings and alarms graph data |

<a id="installationsidsitewidgetsbatteryexternalrelaystatecommand"></a>
# **InstallationsIdSiteWidgetsBatteryExternalRelayStateCommand**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsBatteryExternalRelayStateCommand (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Battery external relay state graph data

Retrieves battery external relay state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsBatteryExternalRelayStateCommandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Battery external relay state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsBatteryExternalRelayStateCommand(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsBatteryExternalRelayStateCommand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsBatteryExternalRelayStateCommandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Battery external relay state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsBatteryExternalRelayStateCommandWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsBatteryExternalRelayStateCommandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsbatterymonitorwarningsandalarms"></a>
# **InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarms**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarms (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Battery monitor warnings and alarms graph data

Retrieves battery monitor warnings and alarms data for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Battery monitor warnings and alarms graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarms(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Battery monitor warnings and alarms graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarmsWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsBatteryMonitorWarningsAndAlarmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsbatteryrelaystate"></a>
# **InstallationsIdSiteWidgetsBatteryRelayState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsBatteryRelayState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Battery relay state graph data

Retrieves battery relay state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsBatteryRelayStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Battery relay state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsBatteryRelayState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsBatteryRelayState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsBatteryRelayStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Battery relay state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsBatteryRelayStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsBatteryRelayStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetschargerrelaystate"></a>
# **InstallationsIdSiteWidgetsChargerRelayState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsChargerRelayState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Charger relay state graph data

Retrieves charger relay state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsChargerRelayStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Charger relay state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsChargerRelayState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsChargerRelayState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsChargerRelayStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger relay state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsChargerRelayStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsChargerRelayStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetschargerstate"></a>
# **InstallationsIdSiteWidgetsChargerState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsChargerState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Charger state graph data

Retrieves charger state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsChargerStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Charger state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsChargerState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsChargerState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsChargerStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsChargerStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsChargerStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsessbatterylifestate"></a>
# **InstallationsIdSiteWidgetsEssBatteryLifeState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsEssBatteryLifeState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

ESS battery life state graph data

Retrieves ESS battery life state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsEssBatteryLifeStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // ESS battery life state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsEssBatteryLifeState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsEssBatteryLifeState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsEssBatteryLifeStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ESS battery life state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsEssBatteryLifeStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsEssBatteryLifeStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsfuelcellstate"></a>
# **InstallationsIdSiteWidgetsFuelCellState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsFuelCellState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Fuel cell state graph data

Retrieves fuel cell state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsFuelCellStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Fuel cell state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsFuelCellState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsFuelCellState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsFuelCellStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fuel cell state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsFuelCellStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsFuelCellStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsgatewayrelaystate"></a>
# **InstallationsIdSiteWidgetsGatewayRelayState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsGatewayRelayState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Gateway relay state graph data

Retrieves gateway relay state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsGatewayRelayStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Gateway relay state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsGatewayRelayState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsGatewayRelayState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsGatewayRelayStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gateway relay state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsGatewayRelayStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsGatewayRelayStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsgatewayrelaytwostate"></a>
# **InstallationsIdSiteWidgetsGatewayRelayTwoState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsGatewayRelayTwoState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Gateway relay two state graph data

Retrieves gateway relay two state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsGatewayRelayTwoStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Gateway relay two state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsGatewayRelayTwoState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsGatewayRelayTwoState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsGatewayRelayTwoStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gateway relay two state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsGatewayRelayTwoStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsGatewayRelayTwoStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsgeneratorstate"></a>
# **InstallationsIdSiteWidgetsGeneratorState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsGeneratorState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Generator state graph data

Retrieves generator state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsGeneratorStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Generator state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsGeneratorState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsGeneratorState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsGeneratorStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generator state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsGeneratorStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsGeneratorStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsinputstate"></a>
# **InstallationsIdSiteWidgetsInputState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsInputState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Input state graph data

Retrieves input state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsInputStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Input state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsInputState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInputState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsInputStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Input state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsInputStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInputStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsinverterchargerstate"></a>
# **InstallationsIdSiteWidgetsInverterChargerState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsInverterChargerState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Inverter charger state graph data

Retrieves inverter charger state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsInverterChargerStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Inverter charger state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsInverterChargerState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInverterChargerState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsInverterChargerStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Inverter charger state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsInverterChargerStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInverterChargerStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsinverterchargerwarningsandalarms"></a>
# **InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarms**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarms (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Inverter charger warnings and alarms graph data

Retrieves inverter warning and alarm state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Inverter charger warnings and alarms graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarms(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Inverter charger warnings and alarms graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarmsWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInverterChargerWarningsAndAlarmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsinverterstate"></a>
# **InstallationsIdSiteWidgetsInverterState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsInverterState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Inverter state graph data

Retrieves inverter state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsInverterStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Inverter state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsInverterState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInverterState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsInverterStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Inverter state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsInverterStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsInverterStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsmpptstate"></a>
# **InstallationsIdSiteWidgetsMPPTState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsMPPTState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

MPPT state graph data

Retrieves MPPT state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsMPPTStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // MPPT state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsMPPTState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsMPPTState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsMPPTStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // MPPT state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsMPPTStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsMPPTStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetssolarchargerrelaystate"></a>
# **InstallationsIdSiteWidgetsSolarChargerRelayState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsSolarChargerRelayState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Solar charger relay state graph data

Retrieves solar charger relay state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsSolarChargerRelayStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Solar charger relay state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsSolarChargerRelayState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsSolarChargerRelayState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsSolarChargerRelayStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Solar charger relay state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsSolarChargerRelayStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsSolarChargerRelayStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsvebusstate"></a>
# **InstallationsIdSiteWidgetsVeBusState**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsVeBusState (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

VE Bus state graph data

Retrieves VE Bus state changes for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsVeBusStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // VE Bus state graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsVeBusState(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsVeBusState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsVeBusStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // VE Bus state graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsVeBusStateWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsVeBusStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsvebuswarningsandalarms"></a>
# **InstallationsIdSiteWidgetsVeBusWarningsAndAlarms**
> InstallationsIdSiteWidgetsGeneratorState200Response InstallationsIdSiteWidgetsVeBusWarningsAndAlarms (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

VE Bus warnings and alarms graph data

Retrieves VE Bus warnings and alarms data for a state graph. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsVeBusWarningsAndAlarmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new StateWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // VE Bus warnings and alarms graph data
                InstallationsIdSiteWidgetsGeneratorState200Response result = apiInstance.InstallationsIdSiteWidgetsVeBusWarningsAndAlarms(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsVeBusWarningsAndAlarms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsVeBusWarningsAndAlarmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // VE Bus warnings and alarms graph data
    ApiResponse<InstallationsIdSiteWidgetsGeneratorState200Response> response = apiInstance.InstallationsIdSiteWidgetsVeBusWarningsAndAlarmsWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StateWidgetsApi.InstallationsIdSiteWidgetsVeBusWarningsAndAlarmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGeneratorState200Response**](InstallationsIdSiteWidgetsGeneratorState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved state changes. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

