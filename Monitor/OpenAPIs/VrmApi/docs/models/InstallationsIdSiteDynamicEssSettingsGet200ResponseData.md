# Org.OpenAPITools.Model.InstallationsIdSiteDynamicEssSettingsGet200ResponseData
Contains the updated configuration for the installation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatteryCapacity** | **decimal** | Battery capacity of the system in kWh | 
**BatteryCosts** | **decimal** | Battery cycle costs per kWh - You can calculate this value using this formula: battery price / (amount of battery cycles * battery capacity) | 
**BatteryFlowRestriction** | **string** | Do you need to disable grid charging or discharging?  * &#x60;unrestricted&#x60; - No  * &#x60;noExport&#x60; - Disable discharging battery to grid  * &#x60;noImport&#x60; - Disable charging battery from grid  | 
**BuyPriceType** | **decimal** | Whether or not you have dynamic buy prices | 
**ChargePower** | **decimal** | Maximum battery charging power in kW | 
**DischargePower** | **decimal** | Maximum battery discharging power in kW | 
**GridSell** | **decimal** | Whether or not you can sell energy to the grid. | 
**IsOn** | **bool** | Whether or not you want to enable Dynamic ESS in VRM | 
**MaxPowerFromGrid** | **decimal** | Maximum power from the grid in kW | 
**MaxPowerToGrid** | **decimal** | Maximum power to the grid in kW | 
**SellPriceType** | **decimal** | Whether or not you have dynamic sell prices | 
**BatteryPrice** | **decimal** | Battery price | [optional] 
**BuyEnergyProviderId** | **decimal** | Identifier of the energy provider for buying energy (see /energy-providers) | [optional] 
**BuyPriceFormula** | **string** | A formula to apply to the raw dynamic energy prices, where p is the raw price. | [optional] 
**BuyPriceSchedule** | [**List&lt;InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInner&gt;**](InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInner.md) |  | [optional] 
**IdBiddingZone** | **decimal** | Identifier of the EU bidding zone (see /bidding-zones) | [optional] 
**IsDessSocDifferent** | **bool** | Whether or not you want to have a separate minimum SOC for Dynamic ESS | [optional] 
**IsGreenModeOn** | **bool** | Whether or not you want to have green mode turned on for Dynamic ESS | [optional] 
**SellEnergyProviderId** | **decimal** | Identifier of the energy provider for buying energy (see /energy-providers) | [optional] 
**SellPriceSchedule** | [**List&lt;InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInner&gt;**](InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInner.md) |  | [optional] 
**SellPriceFormula** | **string** | A formula to apply to the raw dynamic energy prices, where p is the raw price. | [optional] 
**IsPeriodicFullChargeOn** | **bool** | Whether or not do you want to periodically charge your battery to 100% in order to extend battery life | [optional] 
**PeriodicFullChargeDuration** | [**uint**](uint.md) | How many hours should your battery stay at 100% during the periodic recharge | [optional] 
**PeriodicFullChargeInterval** | [**uint**](uint.md) | How often should the battery be fully charged (in days) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

