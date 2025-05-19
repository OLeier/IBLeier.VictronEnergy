# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *https://vrmapi.victronenergy.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersIdUserAccesstokensCreate**](UsersApi.md#usersiduseraccesstokenscreate) | **POST** /users/{idUser}/accesstokens/create | Create an access token for a user. |
| [**UsersIdUserAccesstokensList**](UsersApi.md#usersiduseraccesstokenslist) | **GET** /users/{idUser}/accesstokens/list | List all access tokens for a user. |
| [**UsersIdUserAccesstokensRevoke**](UsersApi.md#usersiduseraccesstokensrevoke) | **GET** /users/{idUser}/accesstokens/{idAccessToken}/revoke | Revoke an access token for a user. |
| [**UsersIdUserAddsite**](UsersApi.md#usersiduseraddsite) | **POST** /users/{idUser}/addsite | Adds a new site |
| [**UsersIdUserGetSiteId**](UsersApi.md#usersidusergetsiteid) | **POST** /users/{idUser}/get-site-id | Returns site id given site identifier |
| [**UsersIdUserInstallations**](UsersApi.md#usersiduserinstallations) | **GET** /users/{idUser}/installations | All installations/sites for a given user |
| [**UsersIdUserSearch**](UsersApi.md#usersidusersearch) | **GET** /users/{idUser}/search | Search |
| [**UsersMe**](UsersApi.md#usersme) | **GET** /users/me | Basic information about logged in user |

<a id="usersiduseraccesstokenscreate"></a>
# **UsersIdUserAccesstokensCreate**
> UsersIdUserAccesstokensCreate200Response UsersIdUserAccesstokensCreate (string xAuthorization, string idUser, UsersIdUserAccesstokensCreateRequest usersIdUserAccesstokensCreateRequest)

Create an access token for a user.

Users can create personal access tokens for usage with external services. These tokens can be used as an alternative way of authentication against the VRM API. The token is returned, after which it is not possible to ever retrieve it again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserAccesstokensCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idUser = "idUser_example";  // string | User id.
            var usersIdUserAccesstokensCreateRequest = new UsersIdUserAccesstokensCreateRequest(); // UsersIdUserAccesstokensCreateRequest | 

            try
            {
                // Create an access token for a user.
                UsersIdUserAccesstokensCreate200Response result = apiInstance.UsersIdUserAccesstokensCreate(xAuthorization, idUser, usersIdUserAccesstokensCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserAccesstokensCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserAccesstokensCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an access token for a user.
    ApiResponse<UsersIdUserAccesstokensCreate200Response> response = apiInstance.UsersIdUserAccesstokensCreateWithHttpInfo(xAuthorization, idUser, usersIdUserAccesstokensCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserAccesstokensCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idUser** | **string** | User id. |  |
| **usersIdUserAccesstokensCreateRequest** | [**UsersIdUserAccesstokensCreateRequest**](UsersIdUserAccesstokensCreateRequest.md) |  |  |

### Return type

[**UsersIdUserAccesstokensCreate200Response**](UsersIdUserAccesstokensCreate200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token created successfully |  -  |
| **4xx** | Token creation failed, returns details about the error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersiduseraccesstokenslist"></a>
# **UsersIdUserAccesstokensList**
> UsersIdUserAccesstokensList200Response UsersIdUserAccesstokensList (string xAuthorization, string idUser)

List all access tokens for a user.

Retrieves a list of all access token details for this user, excluding the actual token itself. Always returns tokens for the requesting user, never for another, regardless of account type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserAccesstokensListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idUser = "idUser_example";  // string | User id.

            try
            {
                // List all access tokens for a user.
                UsersIdUserAccesstokensList200Response result = apiInstance.UsersIdUserAccesstokensList(xAuthorization, idUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserAccesstokensList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserAccesstokensListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all access tokens for a user.
    ApiResponse<UsersIdUserAccesstokensList200Response> response = apiInstance.UsersIdUserAccesstokensListWithHttpInfo(xAuthorization, idUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserAccesstokensListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idUser** | **string** | User id. |  |

### Return type

[**UsersIdUserAccesstokensList200Response**](UsersIdUserAccesstokensList200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tokens retrieved successfully. |  -  |
| **4xx** | Token retrieval failed, returns details about the error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersiduseraccesstokensrevoke"></a>
# **UsersIdUserAccesstokensRevoke**
> UsersIdUserAccesstokensRevoke200Response UsersIdUserAccesstokensRevoke (string xAuthorization, string idUser, string idAccessToken)

Revoke an access token for a user.

Revokes one or more personal access token for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserAccesstokensRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idUser = "idUser_example";  // string | User id.
            var idAccessToken = "idAccessToken_example";  // string | Access token to revoke, or wildcard '*' to revoke all.

            try
            {
                // Revoke an access token for a user.
                UsersIdUserAccesstokensRevoke200Response result = apiInstance.UsersIdUserAccesstokensRevoke(xAuthorization, idUser, idAccessToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserAccesstokensRevoke: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserAccesstokensRevokeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Revoke an access token for a user.
    ApiResponse<UsersIdUserAccesstokensRevoke200Response> response = apiInstance.UsersIdUserAccesstokensRevokeWithHttpInfo(xAuthorization, idUser, idAccessToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserAccesstokensRevokeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idUser** | **string** | User id. |  |
| **idAccessToken** | **string** | Access token to revoke, or wildcard &#39;*&#39; to revoke all. |  |

### Return type

[**UsersIdUserAccesstokensRevoke200Response**](UsersIdUserAccesstokensRevoke200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token(s) revoked successfully |  -  |
| **4xx** | Token creation failed, returns details about the error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersiduseraddsite"></a>
# **UsersIdUserAddsite**
> UsersIdUserAddsite200Response UsersIdUserAddsite (string xAuthorization, UsersIdUserAddsiteRequest usersIdUserAddsiteRequest)

Adds a new site

Adds a new site to the user. An email will be sent when the procedure is done.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserAddsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var usersIdUserAddsiteRequest = new UsersIdUserAddsiteRequest(); // UsersIdUserAddsiteRequest | 

            try
            {
                // Adds a new site
                UsersIdUserAddsite200Response result = apiInstance.UsersIdUserAddsite(xAuthorization, usersIdUserAddsiteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserAddsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserAddsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a new site
    ApiResponse<UsersIdUserAddsite200Response> response = apiInstance.UsersIdUserAddsiteWithHttpInfo(xAuthorization, usersIdUserAddsiteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserAddsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **usersIdUserAddsiteRequest** | [**UsersIdUserAddsiteRequest**](UsersIdUserAddsiteRequest.md) |  |  |

### Return type

[**UsersIdUserAddsite200Response**](UsersIdUserAddsite200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Site added successfully. |  -  |
| **4xx** | The site desired could not be added. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersidusergetsiteid"></a>
# **UsersIdUserGetSiteId**
> UsersIdUserGetSiteId200Response UsersIdUserGetSiteId (string xAuthorization, UsersIdUserAddsiteRequest usersIdUserAddsiteRequest)

Returns site id given site identifier

Retrieves the site id from user's installations given site identifier. Admins can retrieve any installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserGetSiteIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var usersIdUserAddsiteRequest = new UsersIdUserAddsiteRequest(); // UsersIdUserAddsiteRequest | 

            try
            {
                // Returns site id given site identifier
                UsersIdUserGetSiteId200Response result = apiInstance.UsersIdUserGetSiteId(xAuthorization, usersIdUserAddsiteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserGetSiteId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserGetSiteIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns site id given site identifier
    ApiResponse<UsersIdUserGetSiteId200Response> response = apiInstance.UsersIdUserGetSiteIdWithHttpInfo(xAuthorization, usersIdUserAddsiteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserGetSiteIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **usersIdUserAddsiteRequest** | [**UsersIdUserAddsiteRequest**](UsersIdUserAddsiteRequest.md) |  |  |

### Return type

[**UsersIdUserGetSiteId200Response**](UsersIdUserGetSiteId200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved installation. |  -  |
| **4xx** | Token creation failed, returns details about the error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersiduserinstallations"></a>
# **UsersIdUserInstallations**
> UsersIdUserInstallations200Response UsersIdUserInstallations (string xAuthorization, string idUser, int extended = null, int idSite = null)

All installations/sites for a given user

Retrieves a list of installations to which the user is connected. Normal users can only retrieve their own installations, dealers only those of their linked customers and admins those of all users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserInstallationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.
            var idUser = "idUser_example";  // string | User id.
            var extended = 56;  // int | If 1, include all optional response values. (optional) 
            var idSite = 56;  // int | Id of the site we want to retrieve. (optional) 

            try
            {
                // All installations/sites for a given user
                UsersIdUserInstallations200Response result = apiInstance.UsersIdUserInstallations(xAuthorization, idUser, extended, idSite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserInstallations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserInstallationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // All installations/sites for a given user
    ApiResponse<UsersIdUserInstallations200Response> response = apiInstance.UsersIdUserInstallationsWithHttpInfo(xAuthorization, idUser, extended, idSite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserInstallationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |
| **idUser** | **string** | User id. |  |
| **extended** | **int** | If 1, include all optional response values. | [optional]  |
| **idSite** | **int** | Id of the site we want to retrieve. | [optional]  |

### Return type

[**UsersIdUserInstallations200Response**](UsersIdUserInstallations200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved installations. |  -  |
| **403** | Not authorized to view installations for this user. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersidusersearch"></a>
# **UsersIdUserSearch**
> UsersIdUserSearch200Response UsersIdUserSearch (string query)

Search

Search for sites that you have access to based on ID of the site, email of a user, name of a user, serial number of a device attached to a site, site identifier or email domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersIdUserSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var query = foo;  // string | Search term to filter results.

            try
            {
                // Search
                UsersIdUserSearch200Response result = apiInstance.UsersIdUserSearch(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdUserSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersIdUserSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search
    ApiResponse<UsersIdUserSearch200Response> response = apiInstance.UsersIdUserSearchWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersIdUserSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Search term to filter results. |  |

### Return type

[**UsersIdUserSearch200Response**](UsersIdUserSearch200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query was successful. |  -  |
| **400** | Invalid query or missing |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersme"></a>
# **UsersMe**
> UsersMe200Response UsersMe (string xAuthorization)

Basic information about logged in user

Retrieves id, name, email and country of the user that is currently logged in

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vrmapi.victronenergy.com/v2";
            var apiInstance = new UsersApi(config);
            var xAuthorization = Bearer <bearer_token_value>;  // string | The bearer token to use.

            try
            {
                // Basic information about logged in user
                UsersMe200Response result = apiInstance.UsersMe(xAuthorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Basic information about logged in user
    ApiResponse<UsersMe200Response> response = apiInstance.UsersMeWithHttpInfo(xAuthorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAuthorization** | **string** | The bearer token to use. |  |

### Return type

[**UsersMe200Response**](UsersMe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesfully retrieved information. |  -  |
| **401** | User is not logged in (or no bearer token). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

