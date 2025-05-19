# Org.OpenAPITools.Api.InstallationsApi

All URIs are relative to *https://vrmapi.victronenergy.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InstallationOverviewDownload**](InstallationsApi.md#installationoverviewdownload) | **POST** /installation-overview-download | Download installation overview |
| [**InstallationsIdSiteAlarmsDelete**](InstallationsApi.md#installationsidsitealarmsdelete) | **DELETE** /installations/{idSite}/alarms | Delete Alarm |
| [**InstallationsIdSiteAlarmsGet**](InstallationsApi.md#installationsidsitealarmsget) | **GET** /installations/{idSite}/alarms | Get Alarms |
| [**InstallationsIdSiteAlarmsPost**](InstallationsApi.md#installationsidsitealarmspost) | **POST** /installations/{idSite}/alarms | Add Alarm |
| [**InstallationsIdSiteAlarmsPut**](InstallationsApi.md#installationsidsitealarmsput) | **PUT** /installations/{idSite}/alarms | Edit Alarm |
| [**InstallationsIdSiteClearAlarm**](InstallationsApi.md#installationsidsiteclearalarm) | **POST** /installations/{idSite}/clear-alarm | Clear alarm |
| [**InstallationsIdSiteCustomWidgetDelete**](InstallationsApi.md#installationsidsitecustomwidgetdelete) | **DELETE** /installations/{idSite}/custom-widget | Delete Custom Widget |
| [**InstallationsIdSiteCustomWidgetGet**](InstallationsApi.md#installationsidsitecustomwidgetget) | **GET** /installations/{idSite}/custom-widget | Get Custom Widgets |
| [**InstallationsIdSiteCustomWidgetPatch**](InstallationsApi.md#installationsidsitecustomwidgetpatch) | **PATCH** /installations/{idSite}/custom-widget | Update Custom Widget |
| [**InstallationsIdSiteCustomWidgetPost**](InstallationsApi.md#installationsidsitecustomwidgetpost) | **POST** /installations/{idSite}/custom-widget | Create Custom Widget |
| [**InstallationsIdSiteDataDownload**](InstallationsApi.md#installationsidsitedatadownload) | **GET** /installations/{idSite}/data-download | Download installation data |
| [**InstallationsIdSiteDiagnostics**](InstallationsApi.md#installationsidsitediagnostics) | **GET** /installations/{idSite}/diagnostics | Diagnostic data for an installation |
| [**InstallationsIdSiteDynamicEssSettingsGet**](InstallationsApi.md#installationsidsitedynamicesssettingsget) | **GET** /installations/{idSite}/dynamic-ess-settings | Dynamic ESS configuration |
| [**InstallationsIdSiteDynamicEssSettingsPost**](InstallationsApi.md#installationsidsitedynamicesssettingspost) | **POST** /installations/{idSite}/dynamic-ess-settings | Dynamic ESS configuration |
| [**InstallationsIdSiteGpsDownload**](InstallationsApi.md#installationsidsitegpsdownload) | **GET** /installations/{idSite}/gps-download | GPS tracks for an installation |
| [**InstallationsIdSiteInvitePost**](InstallationsApi.md#installationsidsiteinvitepost) | **POST** /installations/{idSite}/invite | Invite user to installation |
| [**InstallationsIdSiteOverallstats**](InstallationsApi.md#installationsidsiteoverallstats) | **GET** /installations/{idSite}/overallstats | Overall installation stats |
| [**InstallationsIdSiteResetForecastsGet**](InstallationsApi.md#installationsidsiteresetforecastsget) | **GET** /installations/{idSite}/reset-forecasts | Retrieves the timestamp of the last forecasts reset |
| [**InstallationsIdSiteResetForecastsPost**](InstallationsApi.md#installationsidsiteresetforecastspost) | **POST** /installations/{idSite}/reset-forecasts | Reset installation forecasts |
| [**InstallationsIdSiteSettings**](InstallationsApi.md#installationsidsitesettings) | **POST** /installations/{idSite}/settings | Update settings for a specific installation |
| [**InstallationsIdSiteStats**](InstallationsApi.md#installationsidsitestats) | **GET** /installations/{idSite}/stats | Installation stats |
| [**InstallationsIdSiteSystemOverview**](InstallationsApi.md#installationsidsitesystemoverview) | **GET** /installations/{idSite}/system-overview | Connected devices for a given installation |
| [**InstallationsIdSiteTagsDelete**](InstallationsApi.md#installationsidsitetagsdelete) | **DELETE** /installations/{idSite}/tags | Remove installation tag |
| [**InstallationsIdSiteTagsGet**](InstallationsApi.md#installationsidsitetagsget) | **GET** /installations/{idSite}/tags | Get installation tags |
| [**InstallationsIdSiteTagsPut**](InstallationsApi.md#installationsidsitetagsput) | **PUT** /installations/{idSite}/tags | Add installation tag |

<a id="installationoverviewdownload"></a>
# **InstallationOverviewDownload**
> InstallationOverviewDownload200Response InstallationOverviewDownload (InstallationOverviewDownloadRequest installationOverviewDownloadRequest,  UNKNOWN_PARAMETER_NAME = null)

Download installation overview

Fetches a customized overview of installations with specified columns, site IDs, and settings. The response can be either JSON or an XLSX file depending on the `jsonResponse` parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationOverviewDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var installationOverviewDownloadRequest = new InstallationOverviewDownloadRequest(); // InstallationOverviewDownloadRequest | 
            var UNKNOWN_PARAMETER_NAME = new (); //  |  (optional) 

            try
            {
                // Download installation overview
                InstallationOverviewDownload200Response result = apiInstance.InstallationOverviewDownload(installationOverviewDownloadRequest, UNKNOWN_PARAMETER_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationOverviewDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationOverviewDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download installation overview
    ApiResponse<InstallationOverviewDownload200Response> response = apiInstance.InstallationOverviewDownloadWithHttpInfo(installationOverviewDownloadRequest, UNKNOWN_PARAMETER_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationOverviewDownloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **installationOverviewDownloadRequest** | [**InstallationOverviewDownloadRequest**](InstallationOverviewDownloadRequest.md) |  |  |
| **UNKNOWN_PARAMETER_NAME** | [****](.md) |  | [optional]  |

### Return type

[**InstallationOverviewDownload200Response**](InstallationOverviewDownload200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the installation overview. |  -  |
| **400** | Invalid request format or missing parameters. |  -  |
| **403** | Not authorized to access installation overview data. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitealarmsdelete"></a>
# **InstallationsIdSiteAlarmsDelete**
> InstallationsIdSiteAlarmsDelete200Response InstallationsIdSiteAlarmsDelete (string xAuthorization, decimal idSite, InstallationsIdSiteAlarmsDeleteRequest installationsIdSiteAlarmsDeleteRequest)

Delete Alarm

Deletes an alarm already linked to an installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteAlarmsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID
            var installationsIdSiteAlarmsDeleteRequest = new InstallationsIdSiteAlarmsDeleteRequest(); // InstallationsIdSiteAlarmsDeleteRequest | 

            try
            {
                // Delete Alarm
                InstallationsIdSiteAlarmsDelete200Response result = apiInstance.InstallationsIdSiteAlarmsDelete(xAuthorization, idSite, installationsIdSiteAlarmsDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteAlarmsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Alarm
    ApiResponse<InstallationsIdSiteAlarmsDelete200Response> response = apiInstance.InstallationsIdSiteAlarmsDeleteWithHttpInfo(xAuthorization, idSite, installationsIdSiteAlarmsDeleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |
| **installationsIdSiteAlarmsDeleteRequest** | [**InstallationsIdSiteAlarmsDeleteRequest**](InstallationsIdSiteAlarmsDeleteRequest.md) |  |  |

### Return type

[**InstallationsIdSiteAlarmsDelete200Response**](InstallationsIdSiteAlarmsDelete200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **4xx** | Could not delete alarm |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitealarmsget"></a>
# **InstallationsIdSiteAlarmsGet**
> InstallationsIdSiteAlarmsGet200Response InstallationsIdSiteAlarmsGet (string xAuthorization, decimal idSite)

Get Alarms

Gets all information about alarms for a specific installation. Next to that, it also receives all data required to create new alarms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteAlarmsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID

            try
            {
                // Get Alarms
                InstallationsIdSiteAlarmsGet200Response result = apiInstance.InstallationsIdSiteAlarmsGet(xAuthorization, idSite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteAlarmsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Alarms
    ApiResponse<InstallationsIdSiteAlarmsGet200Response> response = apiInstance.InstallationsIdSiteAlarmsGetWithHttpInfo(xAuthorization, idSite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |

### Return type

[**InstallationsIdSiteAlarmsGet200Response**](InstallationsIdSiteAlarmsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieves all alarms from an installation, eligible users for those alarms and available data attributes. |  -  |
| **4xx** | Alarms not available |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitealarmspost"></a>
# **InstallationsIdSiteAlarmsPost**
> InstallationsIdSiteAlarmsPost200Response InstallationsIdSiteAlarmsPost (string xAuthorization, decimal idSite, InstallationsIdSiteAlarmsPutRequest installationsIdSiteAlarmsPutRequest)

Add Alarm

Adds an alarm to an installation. Note that there are two different types of alarms; alarms on enums and alarms on numbers (floats). Note that for floats the AlarmEnabled and NotifyAfterSeconds use PascalCase and for enums they use camelCase. You'll get a warning if the wrong case is used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteAlarmsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID
            var installationsIdSiteAlarmsPutRequest = new InstallationsIdSiteAlarmsPutRequest(); // InstallationsIdSiteAlarmsPutRequest | 

            try
            {
                // Add Alarm
                InstallationsIdSiteAlarmsPost200Response result = apiInstance.InstallationsIdSiteAlarmsPost(xAuthorization, idSite, installationsIdSiteAlarmsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteAlarmsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Alarm
    ApiResponse<InstallationsIdSiteAlarmsPost200Response> response = apiInstance.InstallationsIdSiteAlarmsPostWithHttpInfo(xAuthorization, idSite, installationsIdSiteAlarmsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |
| **installationsIdSiteAlarmsPutRequest** | [**InstallationsIdSiteAlarmsPutRequest**](InstallationsIdSiteAlarmsPutRequest.md) |  |  |

### Return type

[**InstallationsIdSiteAlarmsPost200Response**](InstallationsIdSiteAlarmsPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully added an alarm. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitealarmsput"></a>
# **InstallationsIdSiteAlarmsPut**
> InstallationsIdSiteAlarmsPut200Response InstallationsIdSiteAlarmsPut (string xAuthorization, decimal idSite, InstallationsIdSiteAlarmsPutRequest installationsIdSiteAlarmsPutRequest)

Edit Alarm

Edits an alarm already linked to an installation. Note that there are two different types of alarms; alarms on enums and alarms on numbers (floats). Note that for floats the AlarmEnabled and NotifyAfterSeconds use PascalCase and for enums they use camelCase. You'll get a warning if the wrong case is used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteAlarmsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID
            var installationsIdSiteAlarmsPutRequest = new InstallationsIdSiteAlarmsPutRequest(); // InstallationsIdSiteAlarmsPutRequest | 

            try
            {
                // Edit Alarm
                InstallationsIdSiteAlarmsPut200Response result = apiInstance.InstallationsIdSiteAlarmsPut(xAuthorization, idSite, installationsIdSiteAlarmsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteAlarmsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit Alarm
    ApiResponse<InstallationsIdSiteAlarmsPut200Response> response = apiInstance.InstallationsIdSiteAlarmsPutWithHttpInfo(xAuthorization, idSite, installationsIdSiteAlarmsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteAlarmsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |
| **installationsIdSiteAlarmsPutRequest** | [**InstallationsIdSiteAlarmsPutRequest**](InstallationsIdSiteAlarmsPutRequest.md) |  |  |

### Return type

[**InstallationsIdSiteAlarmsPut200Response**](InstallationsIdSiteAlarmsPut200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully added an alarm. |  -  |
| **4xx** | Alarm not added |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsiteclearalarm"></a>
# **InstallationsIdSiteClearAlarm**
> InstallationsIdSiteClearAlarm200Response InstallationsIdSiteClearAlarm (string xAuthorization, string idSite, InstallationsIdSiteClearAlarmRequest installationsIdSiteClearAlarmRequest)

Clear alarm

Clears alarms and marks them as cleared by the user in Event Logs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteClearAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | ID of the installation.
            var installationsIdSiteClearAlarmRequest = new InstallationsIdSiteClearAlarmRequest(); // InstallationsIdSiteClearAlarmRequest | 

            try
            {
                // Clear alarm
                InstallationsIdSiteClearAlarm200Response result = apiInstance.InstallationsIdSiteClearAlarm(xAuthorization, idSite, installationsIdSiteClearAlarmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteClearAlarm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteClearAlarmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear alarm
    ApiResponse<InstallationsIdSiteClearAlarm200Response> response = apiInstance.InstallationsIdSiteClearAlarmWithHttpInfo(xAuthorization, idSite, installationsIdSiteClearAlarmRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteClearAlarmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | ID of the installation. |  |
| **installationsIdSiteClearAlarmRequest** | [**InstallationsIdSiteClearAlarmRequest**](InstallationsIdSiteClearAlarmRequest.md) |  |  |

### Return type

[**InstallationsIdSiteClearAlarm200Response**](InstallationsIdSiteClearAlarm200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Alarm cleared successfully. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitecustomwidgetdelete"></a>
# **InstallationsIdSiteCustomWidgetDelete**
> InstallationsIdSiteResetForecastsPost200Response InstallationsIdSiteCustomWidgetDelete (string xAuthorization, string idSite, InstallationsIdSiteCustomWidgetDeleteRequest installationsIdSiteCustomWidgetDeleteRequest)

Delete Custom Widget

Delete a custom widget

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteCustomWidgetDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | ID of the installation.
            var installationsIdSiteCustomWidgetDeleteRequest = new InstallationsIdSiteCustomWidgetDeleteRequest(); // InstallationsIdSiteCustomWidgetDeleteRequest | 

            try
            {
                // Delete Custom Widget
                InstallationsIdSiteResetForecastsPost200Response result = apiInstance.InstallationsIdSiteCustomWidgetDelete(xAuthorization, idSite, installationsIdSiteCustomWidgetDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteCustomWidgetDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Custom Widget
    ApiResponse<InstallationsIdSiteResetForecastsPost200Response> response = apiInstance.InstallationsIdSiteCustomWidgetDeleteWithHttpInfo(xAuthorization, idSite, installationsIdSiteCustomWidgetDeleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | ID of the installation. |  |
| **installationsIdSiteCustomWidgetDeleteRequest** | [**InstallationsIdSiteCustomWidgetDeleteRequest**](InstallationsIdSiteCustomWidgetDeleteRequest.md) |  |  |

### Return type

[**InstallationsIdSiteResetForecastsPost200Response**](InstallationsIdSiteResetForecastsPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom widget deleted successfully. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitecustomwidgetget"></a>
# **InstallationsIdSiteCustomWidgetGet**
> InstallationsIdSiteCustomWidgetGet200Response InstallationsIdSiteCustomWidgetGet (string xAuthorization, decimal idSite, decimal idCustomWidget)

Get Custom Widgets

Get a custom widget

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteCustomWidgetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | ID of the installation.
            var idCustomWidget = 8.14D;  // decimal | ID of the custom widget

            try
            {
                // Get Custom Widgets
                InstallationsIdSiteCustomWidgetGet200Response result = apiInstance.InstallationsIdSiteCustomWidgetGet(xAuthorization, idSite, idCustomWidget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteCustomWidgetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Custom Widgets
    ApiResponse<InstallationsIdSiteCustomWidgetGet200Response> response = apiInstance.InstallationsIdSiteCustomWidgetGetWithHttpInfo(xAuthorization, idSite, idCustomWidget);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | ID of the installation. |  |
| **idCustomWidget** | **decimal** | ID of the custom widget |  |

### Return type

[**InstallationsIdSiteCustomWidgetGet200Response**](InstallationsIdSiteCustomWidgetGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom Widget data received successfully. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitecustomwidgetpatch"></a>
# **InstallationsIdSiteCustomWidgetPatch**
> InstallationsIdSiteResetForecastsPost200Response InstallationsIdSiteCustomWidgetPatch (string xAuthorization, string idSite, InstallationsIdSiteCustomWidgetPatchRequest installationsIdSiteCustomWidgetPatchRequest)

Update Custom Widget

Update a custom widget

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteCustomWidgetPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | ID of the installation.
            var installationsIdSiteCustomWidgetPatchRequest = new InstallationsIdSiteCustomWidgetPatchRequest(); // InstallationsIdSiteCustomWidgetPatchRequest | 

            try
            {
                // Update Custom Widget
                InstallationsIdSiteResetForecastsPost200Response result = apiInstance.InstallationsIdSiteCustomWidgetPatch(xAuthorization, idSite, installationsIdSiteCustomWidgetPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteCustomWidgetPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Custom Widget
    ApiResponse<InstallationsIdSiteResetForecastsPost200Response> response = apiInstance.InstallationsIdSiteCustomWidgetPatchWithHttpInfo(xAuthorization, idSite, installationsIdSiteCustomWidgetPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | ID of the installation. |  |
| **installationsIdSiteCustomWidgetPatchRequest** | [**InstallationsIdSiteCustomWidgetPatchRequest**](InstallationsIdSiteCustomWidgetPatchRequest.md) |  |  |

### Return type

[**InstallationsIdSiteResetForecastsPost200Response**](InstallationsIdSiteResetForecastsPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom widget updated successfully. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitecustomwidgetpost"></a>
# **InstallationsIdSiteCustomWidgetPost**
> InstallationsIdSiteCustomWidgetPost200Response InstallationsIdSiteCustomWidgetPost (string xAuthorization, decimal idSite, InstallationsIdSiteCustomWidgetPostRequest installationsIdSiteCustomWidgetPostRequest)

Create Custom Widget

Create a custom widget

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteCustomWidgetPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | ID of the installation.
            var installationsIdSiteCustomWidgetPostRequest = new InstallationsIdSiteCustomWidgetPostRequest(); // InstallationsIdSiteCustomWidgetPostRequest | 

            try
            {
                // Create Custom Widget
                InstallationsIdSiteCustomWidgetPost200Response result = apiInstance.InstallationsIdSiteCustomWidgetPost(xAuthorization, idSite, installationsIdSiteCustomWidgetPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteCustomWidgetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Custom Widget
    ApiResponse<InstallationsIdSiteCustomWidgetPost200Response> response = apiInstance.InstallationsIdSiteCustomWidgetPostWithHttpInfo(xAuthorization, idSite, installationsIdSiteCustomWidgetPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteCustomWidgetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | ID of the installation. |  |
| **installationsIdSiteCustomWidgetPostRequest** | [**InstallationsIdSiteCustomWidgetPostRequest**](InstallationsIdSiteCustomWidgetPostRequest.md) |  |  |

### Return type

[**InstallationsIdSiteCustomWidgetPost200Response**](InstallationsIdSiteCustomWidgetPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom widget created successfully. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitedatadownload"></a>
# **InstallationsIdSiteDataDownload**
> InstallationsIdSiteDataDownload200Response InstallationsIdSiteDataDownload (string xAuthorization, string idSite, int start = null, int end = null, string datatype = null, string format = null, bool debug = null, bool async = null)

Download installation data

Retrieves a base64 encoded string containing the specified installation data, in the specified format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteDataDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 
            var datatype = "log";  // string | Type of data to export, defaults to log. (optional) 
            var format = "csv";  // string | Export data file format, defaults to csv. (optional) 
            var debug = true;  // bool | Include debug attributes, only for admins and restricted admins, defaults to false. (optional) 
            var async = true;  // bool | If true, the request is executed asynchronously and the result is not included in the response but sent to the email address of the requesting account. (optional) 

            try
            {
                // Download installation data
                InstallationsIdSiteDataDownload200Response result = apiInstance.InstallationsIdSiteDataDownload(xAuthorization, idSite, start, end, datatype, format, debug, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDataDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteDataDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download installation data
    ApiResponse<InstallationsIdSiteDataDownload200Response> response = apiInstance.InstallationsIdSiteDataDownloadWithHttpInfo(xAuthorization, idSite, start, end, datatype, format, debug, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDataDownloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |
| **datatype** | **string** | Type of data to export, defaults to log. | [optional]  |
| **format** | **string** | Export data file format, defaults to csv. | [optional]  |
| **debug** | **bool** | Include debug attributes, only for admins and restricted admins, defaults to false. | [optional]  |
| **async** | **bool** | If true, the request is executed asynchronously and the result is not included in the response but sent to the email address of the requesting account. | [optional]  |

### Return type

[**InstallationsIdSiteDataDownload200Response**](InstallationsIdSiteDataDownload200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html, text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully exported / started exporting data. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitediagnostics"></a>
# **InstallationsIdSiteDiagnostics**
> InstallationsIdSiteDiagnostics200Response InstallationsIdSiteDiagnostics (string xAuthorization, string idSite, int count = null, int page = null)

Diagnostic data for an installation

Retrieves log data for an installation. This endpoint is only accessible to users with access to the installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteDiagnosticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var count = 56;  // int | How many records to fetch, 100 if not specified. (optional) 
            var page = 56;  // int | Which page to fetch, 1 if not specified. (optional) 

            try
            {
                // Diagnostic data for an installation
                InstallationsIdSiteDiagnostics200Response result = apiInstance.InstallationsIdSiteDiagnostics(xAuthorization, idSite, count, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDiagnostics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteDiagnosticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Diagnostic data for an installation
    ApiResponse<InstallationsIdSiteDiagnostics200Response> response = apiInstance.InstallationsIdSiteDiagnosticsWithHttpInfo(xAuthorization, idSite, count, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDiagnosticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **count** | **int** | How many records to fetch, 100 if not specified. | [optional]  |
| **page** | **int** | Which page to fetch, 1 if not specified. | [optional]  |

### Return type

[**InstallationsIdSiteDiagnostics200Response**](InstallationsIdSiteDiagnostics200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved logging data. |  -  |
| **403** | Not authorized to get log data for this installation. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitedynamicesssettingsget"></a>
# **InstallationsIdSiteDynamicEssSettingsGet**
> InstallationsIdSiteDynamicEssSettingsGet200Response InstallationsIdSiteDynamicEssSettingsGet (int id, string xAuthorization)

Dynamic ESS configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteDynamicEssSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var id = 56;  // int | The ID of the installation
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.

            try
            {
                // Dynamic ESS configuration
                InstallationsIdSiteDynamicEssSettingsGet200Response result = apiInstance.InstallationsIdSiteDynamicEssSettingsGet(id, xAuthorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDynamicEssSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteDynamicEssSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dynamic ESS configuration
    ApiResponse<InstallationsIdSiteDynamicEssSettingsGet200Response> response = apiInstance.InstallationsIdSiteDynamicEssSettingsGetWithHttpInfo(id, xAuthorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDynamicEssSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the installation |  |
| **xAuthorization** | **string** | The bearer token to use. |  |

### Return type

[**InstallationsIdSiteDynamicEssSettingsGet200Response**](InstallationsIdSiteDynamicEssSettingsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the Dynamic ESS configuration for this installation. |  -  |
| **403** | User is not authorized to access or modify this installation. |  -  |
| **404** | Installation not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitedynamicesssettingspost"></a>
# **InstallationsIdSiteDynamicEssSettingsPost**
> InstallationsIdSiteDynamicEssSettingsGet200Response InstallationsIdSiteDynamicEssSettingsPost (int id, string xAuthorization, InstallationsIdSiteDynamicEssSettingsPostRequest installationsIdSiteDynamicEssSettingsPostRequest = null)

Dynamic ESS configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteDynamicEssSettingsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var id = 56;  // int | The ID of the installation
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var installationsIdSiteDynamicEssSettingsPostRequest = new InstallationsIdSiteDynamicEssSettingsPostRequest(); // InstallationsIdSiteDynamicEssSettingsPostRequest |  (optional) 

            try
            {
                // Dynamic ESS configuration
                InstallationsIdSiteDynamicEssSettingsGet200Response result = apiInstance.InstallationsIdSiteDynamicEssSettingsPost(id, xAuthorization, installationsIdSiteDynamicEssSettingsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDynamicEssSettingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteDynamicEssSettingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dynamic ESS configuration
    ApiResponse<InstallationsIdSiteDynamicEssSettingsGet200Response> response = apiInstance.InstallationsIdSiteDynamicEssSettingsPostWithHttpInfo(id, xAuthorization, installationsIdSiteDynamicEssSettingsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteDynamicEssSettingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the installation |  |
| **xAuthorization** | **string** | The bearer token to use. |  |
| **installationsIdSiteDynamicEssSettingsPostRequest** | [**InstallationsIdSiteDynamicEssSettingsPostRequest**](InstallationsIdSiteDynamicEssSettingsPostRequest.md) |  | [optional]  |

### Return type

[**InstallationsIdSiteDynamicEssSettingsGet200Response**](InstallationsIdSiteDynamicEssSettingsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the Dynamic ESS configuration for this installation. |  -  |
| **403** | User is not authorized to access or modify this installation. |  -  |
| **404** | Installation not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitegpsdownload"></a>
# **InstallationsIdSiteGpsDownload**
> void InstallationsIdSiteGpsDownload (string xAuthorization, string idSite, int start, int end)

GPS tracks for an installation

Retrieves GPS tracks for an installation as a KML file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteGpsDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var start = 56;  // int | Timestamp from which to fetch data.
            var end = 56;  // int | Timestamp to which to fetch data.

            try
            {
                // GPS tracks for an installation
                apiInstance.InstallationsIdSiteGpsDownload(xAuthorization, idSite, start, end);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteGpsDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteGpsDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GPS tracks for an installation
    apiInstance.InstallationsIdSiteGpsDownloadWithHttpInfo(xAuthorization, idSite, start, end);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteGpsDownloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **start** | **int** | Timestamp from which to fetch data. |  |
| **end** | **int** | Timestamp to which to fetch data. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.google-earth.kml+xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created KML file containing tracks. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsiteinvitepost"></a>
# **InstallationsIdSiteInvitePost**
> InstallationsIdSiteInvitePost200Response InstallationsIdSiteInvitePost (string xAuthorization, decimal idSite, InstallationsIdSiteInvitePostRequest installationsIdSiteInvitePostRequest)

Invite user to installation

Sends an invitation to a user to gain access to a specific installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteInvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID
            var installationsIdSiteInvitePostRequest = new InstallationsIdSiteInvitePostRequest(); // InstallationsIdSiteInvitePostRequest | 

            try
            {
                // Invite user to installation
                InstallationsIdSiteInvitePost200Response result = apiInstance.InstallationsIdSiteInvitePost(xAuthorization, idSite, installationsIdSiteInvitePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite user to installation
    ApiResponse<InstallationsIdSiteInvitePost200Response> response = apiInstance.InstallationsIdSiteInvitePostWithHttpInfo(xAuthorization, idSite, installationsIdSiteInvitePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |
| **installationsIdSiteInvitePostRequest** | [**InstallationsIdSiteInvitePostRequest**](InstallationsIdSiteInvitePostRequest.md) |  |  |

### Return type

[**InstallationsIdSiteInvitePost200Response**](InstallationsIdSiteInvitePost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invitation sent. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsiteoverallstats"></a>
# **InstallationsIdSiteOverallstats**
> InstallationsIdSiteOverallstats200Response InstallationsIdSiteOverallstats (string xAuthorization, string idSite, string type = null, string attributeCodes = null)

Overall installation stats

Retrieves installation stats grouped by the last year, month, week and day. If the datatype is set to custom, one or more attributes can be provided using the attributeCodes[] parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteOverallstatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var type = "venus";  // string | Type of data to fetch, defaults to live_feed. If set to custom, the attributeCodes[] parameter must be provided. (optional) 
            var attributeCodes = "attributeCodes_example";  // string | Attribute codes for which to retrieve series, repeated for each attribute. Required at least once if datatype is set to custom. (optional) 

            try
            {
                // Overall installation stats
                InstallationsIdSiteOverallstats200Response result = apiInstance.InstallationsIdSiteOverallstats(xAuthorization, idSite, type, attributeCodes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteOverallstats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteOverallstatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overall installation stats
    ApiResponse<InstallationsIdSiteOverallstats200Response> response = apiInstance.InstallationsIdSiteOverallstatsWithHttpInfo(xAuthorization, idSite, type, attributeCodes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteOverallstatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **type** | **string** | Type of data to fetch, defaults to live_feed. If set to custom, the attributeCodes[] parameter must be provided. | [optional]  |
| **attributeCodes** | **string** | Attribute codes for which to retrieve series, repeated for each attribute. Required at least once if datatype is set to custom. | [optional]  |

### Return type

[**InstallationsIdSiteOverallstats200Response**](InstallationsIdSiteOverallstats200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved overall statistics. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsiteresetforecastsget"></a>
# **InstallationsIdSiteResetForecastsGet**
> InstallationsIdSiteResetForecastsGet200Response InstallationsIdSiteResetForecastsGet (string xAuthorization, decimal idSite)

Retrieves the timestamp of the last forecasts reset

Queries influx for the last time the forecasts for this installation were reset. Returns either the timestamp, or 0 if the forecasts were never reset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteResetForecastsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID

            try
            {
                // Retrieves the timestamp of the last forecasts reset
                InstallationsIdSiteResetForecastsGet200Response result = apiInstance.InstallationsIdSiteResetForecastsGet(xAuthorization, idSite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteResetForecastsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteResetForecastsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the timestamp of the last forecasts reset
    ApiResponse<InstallationsIdSiteResetForecastsGet200Response> response = apiInstance.InstallationsIdSiteResetForecastsGetWithHttpInfo(xAuthorization, idSite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteResetForecastsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |

### Return type

[**InstallationsIdSiteResetForecastsGet200Response**](InstallationsIdSiteResetForecastsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | InfluxDB was queried successfully and the timestamp was returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsiteresetforecastspost"></a>
# **InstallationsIdSiteResetForecastsPost**
> InstallationsIdSiteResetForecastsPost200Response InstallationsIdSiteResetForecastsPost (string xAuthorization, decimal idSite, InstallationsIdSiteResetForecastsPostRequest installationsIdSiteResetForecastsPostRequest)

Reset installation forecasts

Logs the current timestamp with the resetType in influx. The forecasting model then ingores all data before this timestamp, effectively treating the installation as if it's a new one

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteResetForecastsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation ID
            var installationsIdSiteResetForecastsPostRequest = new InstallationsIdSiteResetForecastsPostRequest(); // InstallationsIdSiteResetForecastsPostRequest | 

            try
            {
                // Reset installation forecasts
                InstallationsIdSiteResetForecastsPost200Response result = apiInstance.InstallationsIdSiteResetForecastsPost(xAuthorization, idSite, installationsIdSiteResetForecastsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteResetForecastsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteResetForecastsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset installation forecasts
    ApiResponse<InstallationsIdSiteResetForecastsPost200Response> response = apiInstance.InstallationsIdSiteResetForecastsPostWithHttpInfo(xAuthorization, idSite, installationsIdSiteResetForecastsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteResetForecastsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation ID |  |
| **installationsIdSiteResetForecastsPostRequest** | [**InstallationsIdSiteResetForecastsPostRequest**](InstallationsIdSiteResetForecastsPostRequest.md) |  |  |

### Return type

[**InstallationsIdSiteResetForecastsPost200Response**](InstallationsIdSiteResetForecastsPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Forecasts were successfully reset |  -  |
| **400** | Not enough information given in request. Either idSite or resetType is missing. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitesettings"></a>
# **InstallationsIdSiteSettings**
> InstallationsIdSiteSettings200Response InstallationsIdSiteSettings (int id, string xAuthorization, InstallationsIdSiteSettingsRequest installationsIdSiteSettingsRequest = null)

Update settings for a specific installation

Allows the user to modify settings related to a specific installation identified by its ID. You can send one or more of the fields you want to update at once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var id = 56;  // int | The ID of the installation
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var installationsIdSiteSettingsRequest = new InstallationsIdSiteSettingsRequest(); // InstallationsIdSiteSettingsRequest |  (optional) 

            try
            {
                // Update settings for a specific installation
                InstallationsIdSiteSettings200Response result = apiInstance.InstallationsIdSiteSettings(id, xAuthorization, installationsIdSiteSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update settings for a specific installation
    ApiResponse<InstallationsIdSiteSettings200Response> response = apiInstance.InstallationsIdSiteSettingsWithHttpInfo(id, xAuthorization, installationsIdSiteSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the installation |  |
| **xAuthorization** | **string** | The bearer token to use. |  |
| **installationsIdSiteSettingsRequest** | [**InstallationsIdSiteSettingsRequest**](InstallationsIdSiteSettingsRequest.md) |  | [optional]  |

### Return type

[**InstallationsIdSiteSettings200Response**](InstallationsIdSiteSettings200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated settings for the installation. |  -  |
| **403** | User is not authorized to access or modify this installation. |  -  |
| **404** | Installation not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitestats"></a>
# **InstallationsIdSiteStats**
> InstallationsIdSiteStats200Response InstallationsIdSiteStats (string xAuthorization, string idSite, int start = null, int end = null, string type = null, string interval = null, string attributeCodes = null, bool showInstance = null)

Installation stats

Retrieves installation stats for the specified period, or one day if none specified. If the datatype is set to custom, one or more attributes can be provided using the attributeCodes[] parameter.  There is a maximum allowed time period for each interval, which is: * 31 days for 15 minutes * 31 days for hours * 180 days for days * 140 days for weeks * 24 months for months * 5 years for years 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 
            var type = "venus";  // string | Type of data to fetch, defaults to live_feed. If set to custom, the attributeCodes[] parameter must be provided. (optional) 
            var interval = "15mins";  // string | Time between retrieved data points, defaults to hours. (optional) 
            var attributeCodes = "attributeCodes_example";  // string | Attribute codes for which to retrieve series, repeated for each attribute. Required at least once if datatype is set to custom. (optional) 
            var showInstance = true;  // bool | If included, attributes will be grouped by instance. (optional) 

            try
            {
                // Installation stats
                InstallationsIdSiteStats200Response result = apiInstance.InstallationsIdSiteStats(xAuthorization, idSite, start, end, type, interval, attributeCodes, showInstance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Installation stats
    ApiResponse<InstallationsIdSiteStats200Response> response = apiInstance.InstallationsIdSiteStatsWithHttpInfo(xAuthorization, idSite, start, end, type, interval, attributeCodes, showInstance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |
| **type** | **string** | Type of data to fetch, defaults to live_feed. If set to custom, the attributeCodes[] parameter must be provided. | [optional]  |
| **interval** | **string** | Time between retrieved data points, defaults to hours. | [optional]  |
| **attributeCodes** | **string** | Attribute codes for which to retrieve series, repeated for each attribute. Required at least once if datatype is set to custom. | [optional]  |
| **showInstance** | **bool** | If included, attributes will be grouped by instance. | [optional]  |

### Return type

[**InstallationsIdSiteStats200Response**](InstallationsIdSiteStats200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved statistics. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitesystemoverview"></a>
# **InstallationsIdSiteSystemOverview**
> InstallationsIdSiteSystemOverview200Response InstallationsIdSiteSystemOverview (string xAuthorization, string idSite)

Connected devices for a given installation

Retrieves a list of devices to which are connected to this installation. This endpoint is only accessible to users with access to the installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteSystemOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id

            try
            {
                // Connected devices for a given installation
                InstallationsIdSiteSystemOverview200Response result = apiInstance.InstallationsIdSiteSystemOverview(xAuthorization, idSite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteSystemOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteSystemOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connected devices for a given installation
    ApiResponse<InstallationsIdSiteSystemOverview200Response> response = apiInstance.InstallationsIdSiteSystemOverviewWithHttpInfo(xAuthorization, idSite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteSystemOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |

### Return type

[**InstallationsIdSiteSystemOverview200Response**](InstallationsIdSiteSystemOverview200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved devices |  -  |
| **403** | Not authorized to view devices for this installation. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitetagsdelete"></a>
# **InstallationsIdSiteTagsDelete**
> InstallationsIdSiteTagsDelete200Response InstallationsIdSiteTagsDelete (string xAuthorization, decimal idSite, InstallationsIdSiteTagsPutRequest installationsIdSiteTagsPutRequest)

Remove installation tag

Remove tag for an installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteTagsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation id
            var installationsIdSiteTagsPutRequest = new InstallationsIdSiteTagsPutRequest(); // InstallationsIdSiteTagsPutRequest | 

            try
            {
                // Remove installation tag
                InstallationsIdSiteTagsDelete200Response result = apiInstance.InstallationsIdSiteTagsDelete(xAuthorization, idSite, installationsIdSiteTagsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteTagsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteTagsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove installation tag
    ApiResponse<InstallationsIdSiteTagsDelete200Response> response = apiInstance.InstallationsIdSiteTagsDeleteWithHttpInfo(xAuthorization, idSite, installationsIdSiteTagsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteTagsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation id |  |
| **installationsIdSiteTagsPutRequest** | [**InstallationsIdSiteTagsPutRequest**](InstallationsIdSiteTagsPutRequest.md) |  |  |

### Return type

[**InstallationsIdSiteTagsDelete200Response**](InstallationsIdSiteTagsDelete200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tag removed successfully |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitetagsget"></a>
# **InstallationsIdSiteTagsGet**
> InstallationsIdSiteTagsGet200Response InstallationsIdSiteTagsGet (string xAuthorization, decimal idSite)

Get installation tags

Tags for an installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteTagsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation id

            try
            {
                // Get installation tags
                InstallationsIdSiteTagsGet200Response result = apiInstance.InstallationsIdSiteTagsGet(xAuthorization, idSite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteTagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteTagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get installation tags
    ApiResponse<InstallationsIdSiteTagsGet200Response> response = apiInstance.InstallationsIdSiteTagsGetWithHttpInfo(xAuthorization, idSite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteTagsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation id |  |

### Return type

[**InstallationsIdSiteTagsGet200Response**](InstallationsIdSiteTagsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved tags. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitetagsput"></a>
# **InstallationsIdSiteTagsPut**
> InstallationsIdSiteTagsPut200Response InstallationsIdSiteTagsPut (string xAuthorization, decimal idSite, InstallationsIdSiteTagsPutRequest installationsIdSiteTagsPutRequest)

Add installation tag

Add tag for an installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteTagsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new InstallationsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = 8.14D;  // decimal | Installation id
            var installationsIdSiteTagsPutRequest = new InstallationsIdSiteTagsPutRequest(); // InstallationsIdSiteTagsPutRequest | 

            try
            {
                // Add installation tag
                InstallationsIdSiteTagsPut200Response result = apiInstance.InstallationsIdSiteTagsPut(xAuthorization, idSite, installationsIdSiteTagsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteTagsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteTagsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add installation tag
    ApiResponse<InstallationsIdSiteTagsPut200Response> response = apiInstance.InstallationsIdSiteTagsPutWithHttpInfo(xAuthorization, idSite, installationsIdSiteTagsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstallationsApi.InstallationsIdSiteTagsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **decimal** | Installation id |  |
| **installationsIdSiteTagsPutRequest** | [**InstallationsIdSiteTagsPutRequest**](InstallationsIdSiteTagsPutRequest.md) |  |  |

### Return type

[**InstallationsIdSiteTagsPut200Response**](InstallationsIdSiteTagsPut200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tag added successfully |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

