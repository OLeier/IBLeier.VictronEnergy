# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://vrmapi.victronenergy.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthLogin**](DefaultApi.md#authlogin) | **POST** /auth/login | Log in using an e-mail and password |
| [**AuthLoginAsDemo**](DefaultApi.md#authloginasdemo) | **GET** /auth/loginAsDemo | Log in as the demo account |
| [**AuthLogout**](DefaultApi.md#authlogout) | **GET** /auth/logout | Log out using a token |
| [**DataAttributesGet**](DefaultApi.md#dataattributesget) | **GET** /data-attributes | Retrieve filtered and sorted attributes |

<a id="authlogin"></a>
# **AuthLogin**
> AuthLogin200Response AuthLogin (AuthLoginRequest authLoginRequest)

Log in using an e-mail and password

Used to authenticate as a user to access authenticated routes. 2FA token must be included if 2FA is enabled on the account. Returns a bearer token (JWT).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new DefaultApi(config);
            var authLoginRequest = new AuthLoginRequest(); // AuthLoginRequest | 

            try
            {
                // Log in using an e-mail and password
                AuthLogin200Response result = apiInstance.AuthLogin(authLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log in using an e-mail and password
    ApiResponse<AuthLogin200Response> response = apiInstance.AuthLoginWithHttpInfo(authLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AuthLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authLoginRequest** | [**AuthLoginRequest**](AuthLoginRequest.md) |  |  |

### Return type

[**AuthLogin200Response**](AuthLogin200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Login successful, returns bearer token (JWT) |  -  |
| **401** | Login unsuccessful, returns details about the error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="authloginasdemo"></a>
# **AuthLoginAsDemo**
> AuthLoginAsDemo200Response AuthLoginAsDemo ()

Log in as the demo account

Used to authenticate as the demo account. The demo user has limited access to a few demo installations and endpoints, intended for demonstration usage. Returns a bearer token (JWT).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthLoginAsDemoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Log in as the demo account
                AuthLoginAsDemo200Response result = apiInstance.AuthLoginAsDemo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthLoginAsDemo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthLoginAsDemoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log in as the demo account
    ApiResponse<AuthLoginAsDemo200Response> response = apiInstance.AuthLoginAsDemoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AuthLoginAsDemoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AuthLoginAsDemo200Response**](AuthLoginAsDemo200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Login successful, returns bearer token (JWT). |  -  |
| **400** | Login unsuccessful, returns details about the error(s). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="authlogout"></a>
# **AuthLogout**
> AuthLogout200Response AuthLogout (string xAuthorization)

Log out using a token

Used to log out a user. The token provided in the authorization header will be blacklisted from the server and can no longer be used for authentication purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new DefaultApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.

            try
            {
                // Log out using a token
                AuthLogout200Response result = apiInstance.AuthLogout(xAuthorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthLogout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthLogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out using a token
    ApiResponse<AuthLogout200Response> response = apiInstance.AuthLogoutWithHttpInfo(xAuthorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AuthLogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |

### Return type

[**AuthLogout200Response**](AuthLogout200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logout successful. |  -  |
| **4xx** | Something went wrong. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="dataattributesget"></a>
# **DataAttributesGet**
> Dictionary&lt;string, DataAttributesGet200ResponseValue&gt; DataAttributesGet ()

Retrieve filtered and sorted attributes

Returns a JSON object of attributes with `idDataAttribute` as string keys. Filters out `targetTable`, `idDeviceType`, and `idDataAttribute` fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataAttributesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Retrieve filtered and sorted attributes
                Dictionary<string, DataAttributesGet200ResponseValue> result = apiInstance.DataAttributesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DataAttributesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataAttributesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve filtered and sorted attributes
    ApiResponse<Dictionary<string, DataAttributesGet200ResponseValue>> response = apiInstance.DataAttributesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DataAttributesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Dictionary&lt;string, DataAttributesGet200ResponseValue&gt;**](DataAttributesGet200ResponseValue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

