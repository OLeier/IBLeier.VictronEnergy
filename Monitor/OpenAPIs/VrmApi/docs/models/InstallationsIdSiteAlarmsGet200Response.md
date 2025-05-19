# Org.OpenAPITools.Model.InstallationsIdSiteAlarmsGet200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True if the request was successful. | [optional] 
**RateLimited** | **bool** |  | [optional] 
**Alarms** | [**List&lt;InstallationsIdSiteAlarmsGet200ResponseAlarmsInner&gt;**](InstallationsIdSiteAlarmsGet200ResponseAlarmsInner.md) | All alarms that may trigger on this installation | [optional] 
**Devices** | [**List&lt;InstallationsIdSiteAlarmsGet200ResponseDevicesInner&gt;**](InstallationsIdSiteAlarmsGet200ResponseDevicesInner.md) | All devices linked to this installation | [optional] 
**Users** | [**List&lt;InstallationsIdSiteAlarmsGet200ResponseUsersInner&gt;**](InstallationsIdSiteAlarmsGet200ResponseUsersInner.md) | All users for this installation that may or may not receive notifications (mail, SMS) | [optional] 
**Attributes** | [**List&lt;InstallationsIdSiteAlarmsGet200ResponseAttributesInner&gt;**](InstallationsIdSiteAlarmsGet200ResponseAttributesInner.md) | All data attributes that can be used for setting up alarms | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

