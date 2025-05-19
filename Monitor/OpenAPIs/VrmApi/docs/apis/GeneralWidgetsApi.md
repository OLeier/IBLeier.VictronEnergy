# Org.OpenAPITools.Api.GeneralWidgetsApi

All URIs are relative to *https://vrmapi.victronenergy.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InstallationsIdSiteWidgetsGPS**](GeneralWidgetsApi.md#installationsidsitewidgetsgps) | **GET** /installations/{idSite}/widgets/GPS | GPS data for an installation |
| [**InstallationsIdSiteWidgetsGraph**](GeneralWidgetsApi.md#installationsidsitewidgetsgraph) | **GET** /installations/{idSite}/widgets/Graph | Graph series for a given installation and set of attributes |
| [**InstallationsIdSiteWidgetsHoursOfAc**](GeneralWidgetsApi.md#installationsidsitewidgetshoursofac) | **GET** /installations/{idSite}/widgets/HoursOfAc | Hours of AC for an installation |

<a id="installationsidsitewidgetsgps"></a>
# **InstallationsIdSiteWidgetsGPS**
> InstallationsIdSiteWidgetsGPS200Response InstallationsIdSiteWidgetsGPS (string xAuthorization, string idSite, int instance = null)

GPS data for an installation

Retrieves GPS data for the specified installation, used in the GPS widget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsGPSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new GeneralWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 

            try
            {
                // GPS data for an installation
                InstallationsIdSiteWidgetsGPS200Response result = apiInstance.InstallationsIdSiteWidgetsGPS(xAuthorization, idSite, instance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralWidgetsApi.InstallationsIdSiteWidgetsGPS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsGPSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GPS data for an installation
    ApiResponse<InstallationsIdSiteWidgetsGPS200Response> response = apiInstance.InstallationsIdSiteWidgetsGPSWithHttpInfo(xAuthorization, idSite, instance);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralWidgetsApi.InstallationsIdSiteWidgetsGPSWithHttpInfo: " + e.Message);
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

[**InstallationsIdSiteWidgetsGPS200Response**](InstallationsIdSiteWidgetsGPS200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved GPS data. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetsgraph"></a>
# **InstallationsIdSiteWidgetsGraph**
> InstallationsIdSiteWidgetsGraph200Response InstallationsIdSiteWidgetsGraph (string xAuthorization, string idSite, string attributeCodes = null, int attributeIds = null, int instance = null, int start = null, int end = null, int width = null, decimal pointsPerPixel = null, decimal useMinMax = null)

Graph series for a given installation and set of attributes

Retrieves data points for a graph for the given installation and data attributes. Data attributes should be given as id's, codes or both. If not given a timeframe, data for the last day will be retrieved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsGraphExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new GeneralWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var attributeCodes = "attributeCodes_example";  // string | Attribute codes for which to retrieve series, repeated for each attribute. (optional) 
            var attributeIds = 56;  // int | Attribute id's for which to retrieve series, repeated for each attribute. (optional) 
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 
            var width = 56;  // int | Width of the graph in pixels, defaults to 768. (optional) 
            var pointsPerPixel = 8.14D;  // decimal | The amount of datapoints per pixel of the width of the graph, defaults to two. (optional) 
            var useMinMax = 8.14D;  // decimal | If 1, include the mean, min and max for each datapoint. Else, include only one value per datapoint. (optional) 

            try
            {
                // Graph series for a given installation and set of attributes
                InstallationsIdSiteWidgetsGraph200Response result = apiInstance.InstallationsIdSiteWidgetsGraph(xAuthorization, idSite, attributeCodes, attributeIds, instance, start, end, width, pointsPerPixel, useMinMax);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralWidgetsApi.InstallationsIdSiteWidgetsGraph: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsGraphWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Graph series for a given installation and set of attributes
    ApiResponse<InstallationsIdSiteWidgetsGraph200Response> response = apiInstance.InstallationsIdSiteWidgetsGraphWithHttpInfo(xAuthorization, idSite, attributeCodes, attributeIds, instance, start, end, width, pointsPerPixel, useMinMax);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralWidgetsApi.InstallationsIdSiteWidgetsGraphWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idSite** | **string** | Installation id |  |
| **attributeCodes** | **string** | Attribute codes for which to retrieve series, repeated for each attribute. | [optional]  |
| **attributeIds** | **int** | Attribute id&#39;s for which to retrieve series, repeated for each attribute. | [optional]  |
| **instance** | **int** | Instance for which to retrieve data, defaults to 0. | [optional]  |
| **start** | **int** | Timestamp from which to fetch data, defaults to one day ago. | [optional]  |
| **end** | **int** | Timestamp to which to fetch data, defaults to now. | [optional]  |
| **width** | **int** | Width of the graph in pixels, defaults to 768. | [optional]  |
| **pointsPerPixel** | **decimal** | The amount of datapoints per pixel of the width of the graph, defaults to two. | [optional]  |
| **useMinMax** | **decimal** | If 1, include the mean, min and max for each datapoint. Else, include only one value per datapoint. | [optional]  |

### Return type

[**InstallationsIdSiteWidgetsGraph200Response**](InstallationsIdSiteWidgetsGraph200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved graph data points. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installationsidsitewidgetshoursofac"></a>
# **InstallationsIdSiteWidgetsHoursOfAc**
> InstallationsIdSiteWidgetsHoursOfAc200Response InstallationsIdSiteWidgetsHoursOfAc (string xAuthorization, string idSite, int instance = null, int start = null, int end = null)

Hours of AC for an installation

Retrieves hours of AC for an installation. If no timeframe is specified, data from the last day will be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallationsIdSiteWidgetsHoursOfAcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new GeneralWidgetsApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idSite = "idSite_example";  // string | Installation id
            var instance = 56;  // int | Instance for which to retrieve data, defaults to 0. (optional) 
            var start = 56;  // int | Timestamp from which to fetch data, defaults to one day ago. (optional) 
            var end = 56;  // int | Timestamp to which to fetch data, defaults to now. (optional) 

            try
            {
                // Hours of AC for an installation
                InstallationsIdSiteWidgetsHoursOfAc200Response result = apiInstance.InstallationsIdSiteWidgetsHoursOfAc(xAuthorization, idSite, instance, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralWidgetsApi.InstallationsIdSiteWidgetsHoursOfAc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallationsIdSiteWidgetsHoursOfAcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Hours of AC for an installation
    ApiResponse<InstallationsIdSiteWidgetsHoursOfAc200Response> response = apiInstance.InstallationsIdSiteWidgetsHoursOfAcWithHttpInfo(xAuthorization, idSite, instance, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralWidgetsApi.InstallationsIdSiteWidgetsHoursOfAcWithHttpInfo: " + e.Message);
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

[**InstallationsIdSiteWidgetsHoursOfAc200Response**](InstallationsIdSiteWidgetsHoursOfAc200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully calculated and retrieved hours of AC. |  -  |
| **4xx** | Request unsuccessful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

