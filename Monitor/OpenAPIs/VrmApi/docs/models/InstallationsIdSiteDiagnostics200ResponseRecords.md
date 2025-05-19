# Org.OpenAPITools.Model.InstallationsIdSiteDiagnostics200ResponseRecords
Fetched logging data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdSite** | **int** | Installation id. | 
**Timestamp** | **int** | Timestamp at which this data was logged. | 
**Device** | **string** | Logging device name. | 
**Instance** | **int** | Log data instance. | 
**IdDataAttribute** | **int** | Log data attribute id. | 
**Description** | **string** | Log data description. | 
**FormatWithUnit** | **string** | Data attribute string format. | 
**Code** | **string** | Data attribute code. | 
**Bitmask** | **int** | 1 if the data attribute is a bitmask, else 0. | 
**FormattedValue** | **string** | Log data value formatted as a string. | 
**RawValue** | [**InstallationsIdSiteDiagnostics200ResponseRecordsRawValue**](InstallationsIdSiteDiagnostics200ResponseRecordsRawValue.md) |  | 
**Id** | **int** | Log data id. | 
**DbusServiceType** | **string** | Device DBus Service type. | 
**DbusPath** | **string** | Device DBus path. | 
**DataAttributeEnumValues** | [**List&lt;InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner&gt;**](InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner.md) | Data attribute enum values, only for data attributes of type enum. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

