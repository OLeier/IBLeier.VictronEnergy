# Org.OpenAPITools.Model.InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Device name. | 
**ProductCode** | **string** | Device product code. | 
**IdSite** | **int** | Installation to which the device belongs. | 
**LastConnection** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerLastConnection**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerLastConnection.md) |  | 
**Settings** | [**List&lt;InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerSettingsInner&gt;**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerSettingsInner.md) | Device settings. | 
**CustomName** | **string** | Custom device name. | 
**ProductName** | **string** | Device product name. | [optional] 
**FirmwareVersion** | **string** | Detailed firmware version information. | [optional] 
**Class** | **string** | Styling field used for VRM. | [optional] 
**Connection** | **string** | Device connection string. | [optional] 
**Instance** | **int** | Installation instance to which this device belongs. | [optional] 
**IdDeviceType** | **int** | Device type id. | [optional] 
**SignalRSSI** | **string** | Device formatted signal RSSI. | [optional] 
**SignalSNR** | **string** | Device formatted signal SNR. | [optional] 
**SignalFrequency** | **string** | Device formatted signal frequency. | [optional] 
**AntennaType** | **string** | GlobalLink device antenna switch state. | [optional] 
**NetworkName** | **string** | Device network name. | [optional] 
**LoggingInterval** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerLoggingInterval**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerLoggingInterval.md) |  | [optional] 
**Identifier** | **string** | Gateway device identifier, not visible to demo user or using site sharing. | [optional] 
**LastPowerUpOrRestart** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerLastPowerUpOrRestart**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerLastPowerUpOrRestart.md) |  | [optional] 
**MachineSerialNumber** | **string** | Gateway device serial number. | [optional] 
**RemoteOnLan** | **string** | Remote on LAN address, only for Venus OS devices. | [optional] 
**AutoUpdate** | **string** | Auto update setting, only for Venus OS devices. | [optional] 
**UpdateTo** | **string** | Maxiumum version to update to, only for Venus OS devices. | [optional] 
**VncSshAuth** | **bool** | True if the Venus OS gateway has SSH authentication enabled. | [optional] 
**VncStatus** | **string** | Venus OS gateway internet setting. | [optional] 
**VncPort** | **int** | Venus OS gateway remote VNC port. | [optional] 
**TwoWayCommunication** | **bool** | True if the Venus OS gateway has two way communication enabled. | [optional] 
**RemoteSupportEnabled** | **bool** | True if the Venus OS gateway has remote support enabled. | [optional] 
**RemoteSupportPort** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerRemoteSupportPort**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerRemoteSupportPort.md) |  | [optional] 
**RemoteSupportIp** | **string** | Venus OS gateway remote support connection ip. | [optional] 
**RemoteSupport** | **string** | Venus OS gateway remote support status. | [optional] 
**ProductId** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerProductId**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerProductId.md) |  | [optional] 
**Vmc** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerVmc**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerVmc.md) |  | [optional] 
**Vid** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerVid**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerVid.md) |  | [optional] 
**TempSensorConnected** | **bool** | IO Extender device temperature sensor connection, true if connected. | [optional] 
**FroniusDeviceType** | **string** | PV Inverter Fronius device type. | [optional] 
**PL** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerPL**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerPL.md) |  | [optional] 
**PdV** | **string** | PV Inverter device data manager version. | [optional] 
**InputType** | [**InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerInputType**](InstallationsIdSiteSystemOverview200ResponseRecordsDevicesInnerInputType.md) |  | [optional] 
**InputState** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

