# Org.OpenAPITools.Api.SummaryWidgetsApi

All URIs are relative to *https://vrmapi.victronenergy.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InstallationsIdSiteWidgetsBMSDiagnostics**](SummaryWidgetsApi.md#installationsidsitewidgetsbmsdiagnostics) | **GET** /installations/{idSite}/widgets/BMSDiagnostics | BMS diagnostics summary data |
| [**InstallationsIdSiteWidgetsBatterySummary**](SummaryWidgetsApi.md#installationsidsitewidgetsbatterysummary) | **GET** /installations/{idSite}/widgets/BatterySummary | Battery summary data |
| [**InstallationsIdSiteWidgetsDCMeter**](SummaryWidgetsApi.md#installationsidsitewidgetsdcmeter) | **GET** /installations/{idSite}/widgets/DCMeter | DC meter summary data |
| [**InstallationsIdSiteWidgetsEvChargerSummary**](SummaryWidgetsApi.md#installationsidsitewidgetsevchargersummary) | **GET** /installations/{idSite}/widgets/EvChargerSummary | EV charger summary data |
| [**InstallationsIdSiteWidgetsGlobalLinkSummary**](SummaryWidgetsApi.md#installationsidsitewidgetsgloballinksummary) | **GET** /installations/{idSite}/widgets/GlobalLinkSummary | GlobalLink summary data |
| [**InstallationsIdSiteWidgetsHistoricData**](SummaryWidgetsApi.md#installationsidsitewidgetshistoricdata) | **GET** /installations/{idSite}/widgets/HistoricData | Historic summary data |
| [**InstallationsIdSiteWidgetsIOExtenderInOut**](SummaryWidgetsApi.md#installationsidsitewidgetsioextenderinout) | **GET** /installations/{idSite}/widgets/IOExtenderInOut | IO extender input and output summary data |
| [**InstallationsIdSiteWidgetsLithiumBMS**](SummaryWidgetsApi.md#installationsidsitewidgetslithiumbms) | **GET** /installations/{idSite}/widgets/LithiumBMS | Lithium BMS summary data |
| [**InstallationsIdSiteWidgetsMeteorologicalSensor**](SummaryWidgetsApi.md#installationsidsitewidgetsmeteorologicalsensor) | **GET** /installations/{idSite}/widgets/MeteorologicalSensor | Meteorological summary data |
| [**InstallationsIdSiteWidgetsMotorSummary**](SummaryWidgetsApi.md#installationsidsitewidgetsmotorsummary) | **GET** /installations/{idSite}/widgets/MotorSummary | Motor summary data |
| [**InstallationsIdSiteWidgetsPVInverterStatus**](SummaryWidgetsApi.md#installationsidsitewidgetspvinverterstatus) | **GET** /installations/{idSite}/widgets/PVInverterStatus | PV inverter summary data |
| [**InstallationsIdSiteWidgetsSolarChargerSummary**](SummaryWidgetsApi.md#installationsidsitewidgetssolarchargersummary) | **GET** /installations/{idSite}/widgets/SolarChargerSummary | Solar charger summary data |
| [**InstallationsIdSiteWidgetsStatus**](SummaryWidgetsApi.md#installationsidsitewidgetsstatus) | **GET** /installations/{idSite}/widgets/Status | System overview summary data |
| [**InstallationsIdSiteWidgetsTankSummary**](SummaryWidgetsApi.md#installationsidsitewidgetstanksummary) | **GET** /installations/{idSite}/widgets/TankSummary | Tank summary data |
| [**InstallationsIdSiteWidgetsTempSummaryAndGraph**](SummaryWidgetsApi.md#installationsidsitewidgetstempsummaryandgraph) | **GET** /installations/{idSite}/widgets/TempSummaryAndGraph | Temperature summary data |

<a id="installationsidsitewidgetsbmsdiagnostics"></a>
# **InstallationsIdSiteWidgetsBMSDiagnostics**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsBMSDiagnostics (string xAuthorization, string idSite, int instance = null)

BMS diagnostics summary data

Retrieves BMS diagnostics summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsBMSDiagnosticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // BMS diagnostics summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsBMSDiagnostics(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsBMSDiagnostics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsBMSDiagnosticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BMS diagnostics summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsBMSDiagnosticsWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsBMSDiagnosticsWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsbatterysummary"></a>
# **InstallationsIdSiteWidgetsBatterySummary**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsBatterySummary (string xAuthorization, string idSite, int instance = null)

Battery summary data

Retrieves battery summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsBatterySummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Battery summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsBatterySummary(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsBatterySummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsBatterySummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Battery summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsBatterySummaryWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsBatterySummaryWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsdcmeter"></a>
# **InstallationsIdSiteWidgetsDCMeter**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsDCMeter (string xAuthorization, string idSite, int instance = null)

DC meter summary data

Retrieves DC meter summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsDCMeterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // DC meter summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsDCMeter(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsDCMeter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsDCMeterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DC meter summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsDCMeterWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsDCMeterWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsevchargersummary"></a>
# **InstallationsIdSiteWidgetsEvChargerSummary**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsEvChargerSummary (string xAuthorization, string idSite, int instance = null)

EV charger summary data

Retrieves EV charger summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsEvChargerSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // EV charger summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsEvChargerSummary(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsEvChargerSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsEvChargerSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // EV charger summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsEvChargerSummaryWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsEvChargerSummaryWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsgloballinksummary"></a>
# **InstallationsIdSiteWidgetsGlobalLinkSummary**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsGlobalLinkSummary (string xAuthorization, string idSite, int instance = null)

GlobalLink summary data

Retrieves GlobalLink summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsGlobalLinkSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // GlobalLink summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsGlobalLinkSummary(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsGlobalLinkSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsGlobalLinkSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GlobalLink summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsGlobalLinkSummaryWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsGlobalLinkSummaryWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetshistoricdata"></a>
# **InstallationsIdSiteWidgetsHistoricData**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsHistoricData (string xAuthorization, string idSite, int instance = null)

Historic summary data

Retrieves historic summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsHistoricDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Historic summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsHistoricData(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsHistoricData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsHistoricDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historic summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsHistoricDataWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsHistoricDataWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsioextenderinout"></a>
# **InstallationsIdSiteWidgetsIOExtenderInOut**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsIOExtenderInOut (string xAuthorization, string idSite, int instance = null)

IO extender input and output summary data

Retrieves IO extender input and output summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsIOExtenderInOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // IO extender input and output summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsIOExtenderInOut(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsIOExtenderInOut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsIOExtenderInOutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // IO extender input and output summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsIOExtenderInOutWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsIOExtenderInOutWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetslithiumbms"></a>
# **InstallationsIdSiteWidgetsLithiumBMS**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsLithiumBMS (string xAuthorization, string idSite, int instance = null)

Lithium BMS summary data

Retrieves lithium BMS summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsLithiumBMSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Lithium BMS summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsLithiumBMS(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsLithiumBMS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsLithiumBMSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lithium BMS summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsLithiumBMSWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsLithiumBMSWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsmeteorologicalsensor"></a>
# **InstallationsIdSiteWidgetsMeteorologicalSensor**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsMeteorologicalSensor (string xAuthorization, string idSite, int instance = null)

Meteorological summary data

Retrieves meteorological summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsMeteorologicalSensorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Meteorological summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsMeteorologicalSensor(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsMeteorologicalSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsMeteorologicalSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Meteorological summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsMeteorologicalSensorWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsMeteorologicalSensorWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsmotorsummary"></a>
# **InstallationsIdSiteWidgetsMotorSummary**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsMotorSummary (string xAuthorization, string idSite, int instance = null)

Motor summary data

Retrieves motor summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsMotorSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Motor summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsMotorSummary(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsMotorSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsMotorSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Motor summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsMotorSummaryWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsMotorSummaryWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetspvinverterstatus"></a>
# **InstallationsIdSiteWidgetsPVInverterStatus**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsPVInverterStatus (string xAuthorization, string idSite, int instance = null)

PV inverter summary data

Retrieves PV inverter summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsPVInverterStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // PV inverter summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsPVInverterStatus(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsPVInverterStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsPVInverterStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PV inverter summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsPVInverterStatusWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsPVInverterStatusWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetssolarchargersummary"></a>
# **InstallationsIdSiteWidgetsSolarChargerSummary**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsSolarChargerSummary (string xAuthorization, string idSite, int instance = null)

Solar charger summary data

Retrieves solar charger summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsSolarChargerSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Solar charger summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsSolarChargerSummary(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsSolarChargerSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsSolarChargerSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Solar charger summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsSolarChargerSummaryWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsSolarChargerSummaryWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsstatus"></a>
# **InstallationsIdSiteWidgetsStatus**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsStatus (string xAuthorization, string idSite, int instance = null)

System overview summary data

Retrieves system overview summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // System overview summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsStatus(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System overview summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsStatusWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsStatusWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetstanksummary"></a>
# **InstallationsIdSiteWidgetsTankSummary**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsTankSummary (string xAuthorization, string idSite, int instance = null)

Tank summary data

Retrieves tank summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsTankSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Tank summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsTankSummary(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsTankSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsTankSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tank summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsTankSummaryWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsTankSummaryWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetstempsummaryandgraph"></a>
# **InstallationsIdSiteWidgetsTempSummaryAndGraph**
> InstallationsIdSiteWidgetsBatterySummary200Response InstallationsIdSiteWidgetsTempSummaryAndGraph (string xAuthorization, string idSite, int instance = null)

Temperature summary data

Retrieves temperature summary data for an overview, grouped by data attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsTempSummaryAndGraphExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new SummaryWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // Temperature summary data
                InstallationsIdSiteWidgetsBatterySummary200Response result = apiInstance.InstallationsIdSiteWidgetsTempSummaryAndGraph(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsTempSummaryAndGraph: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsTempSummaryAndGraphWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Temperature summary data
    ApiResponse<InstallationsIdSiteWidgetsBatterySummary200Response> response = apiInstance.InstallationsIdSiteWidgetsTempSummaryAndGraphWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SummaryWidgetsApi.InstallationsIdSiteWidgetsTempSummaryAndGraphWithHttpInfo: " + e.Message);
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

### Return type

[**InstallationsIdSiteWidgetsBatterySummary200Response**](InstallationsIdSiteWidgetsBatterySummary200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved summary. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

