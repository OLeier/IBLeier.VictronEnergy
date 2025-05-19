# Org.OpenAPITools.Model.UsersIdUserInstallations200ResponseRecordsInner
A single installation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdSite** | **int** |  | 
**AccessLevel** | **int** | The access level of the requesting user. | 
**Owner** | **bool** | True if the requesting user owns this installation. | 
**IsAdmin** | **bool** | True if the requesting user is an admin for this installation. | 
**Name** | **string** |  | 
**Identifier** | **string** | Installation identifier. | 
**IdUser** | **int** | Installation owner id. | 
**PvMax** | **int** | Maximum PV for this installation. | 
**Timezone** | **string** | Installation local timezone. | 
**GeofenceEnabled** | **bool** | True if the geofence is enabled. | 
**RealtimeUpdates** | **bool** | True if realtime updates are enabled. | 
**HasMains** | **int** | 1 if the installation has mains, else 0. | 
**HasGenerator** | **int** | 1 if the installation has a generator, else 0. | 
**AlarmMonitoring** | **int** | If alarms and warnings should be sent. When 0 nothing is sent out, when 1 only alarms and when 2 both alarms and warnings. | 
**InvalidVRMAuthTokenUsedInLogRequest** | **int** | 1 if an invalid token was used for logging, else 0. | 
**Syscreated** | **int** | Installation creation timestamp, UNIX format. | 
**Shared** | **bool** | True if sitesharing is enabled. | 
**DeviceIcon** | **string** | Installation icon. | 
**Phonenumber** | **string** | Installation phone number. | 
**Notes** | **string** | Installation notes. | 
**Geofence** | **string** | Installation geofence, in json format. | 
**NoDataAlarmTimeout** | **int** | How many seconds after no installation data is received the alarm should go off. | 
**Alarm** | **bool** | True if there is an active alarm. | [optional] 
**LastTimestamp** | **int** | Timestamp of the most recently received data (UNIX format). | [optional] 
**CurrentTime** | **string** | Local time for the installation in 24h format (hh:mm). | [optional] 
**TimezoneOffset** | **int** | How many seconds the installation is ahead of UTC. | [optional] 
**DemoMode** | **bool** | True if the installation is in demo mode. | [optional] 
**MqttWebhost** | **string** | Installation MQTT webhost, as a URL. | [optional] 
**MqttHost** | **string** | Installation MQTT host, as a URL. | [optional] 
**HighWorkload** | **bool** | True if the D-Bus round trip time is higher than the threshold. | [optional] 
**CurrentAlarms** | **List&lt;string&gt;** | A list of the active alarms for this installation. | [optional] 
**NumAlarms** | **int** | The amount of active alarms. | [optional] 
**AvatarUrl** | **string** | The url for this site&#39;s avatar. | [optional] 
**Tags** | [**List&lt;UsersIdUserInstallations200ResponseRecordsInnerTagsInner&gt;**](UsersIdUserInstallations200ResponseRecordsInnerTagsInner.md) | Installation tags. | [optional] 
**Images** | [**List&lt;UsersIdUserInstallations200ResponseRecordsInnerImagesInner&gt;**](UsersIdUserInstallations200ResponseRecordsInnerImagesInner.md) | Installation images. | [optional] 
**ViewPermissions** | [**UsersIdUserInstallations200ResponseRecordsInnerViewPermissions**](UsersIdUserInstallations200ResponseRecordsInnerViewPermissions.md) |  | [optional] 
**Extended** | [**List&lt;UsersIdUserInstallations200ResponseRecordsInnerExtendedInner&gt;**](UsersIdUserInstallations200ResponseRecordsInnerExtendedInner.md) | Extended data about this installation. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

