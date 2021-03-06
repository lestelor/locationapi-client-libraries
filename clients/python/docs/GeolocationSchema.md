# GeolocationSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**token** | **str** |  | [optional] 
**id** | **str** | ID of the device, in case you are in a per-device plan. This could be any unique string such as an IMEI, IMSI, phone number or a hash of any of the previous values, etc. Maximum accepted length is 20 chars, and values should only be alphanumeric (a-z, 0-9) | [optional] 
**radio** | [**RadioSchema**](RadioSchema.md) |  | [optional] 
**mcc** | **int** | \&quot;Mobile Country Code of your operator’s network represented by an integer (Optional). Range: 0 to 999.\&quot; | [optional] 
**mnc** | **int** | Mobile Network Code of your operator’s network represented by an integer (Optional). Range: 0 to 999. On CDMA, provide the System ID or SID, with range: 1 to 32767. | [optional] 
**cells** | [**list[CellSchema]**](CellSchema.md) | An array of cell ID objects | [optional] 
**wifi** | [**list[WifiSchema]**](WifiSchema.md) | An array of WiFi objects visible to the device. | [optional] 
**fallbacks** | [**FallbackSchema**](FallbackSchema.md) |  | [optional] 
**address** | [**GeolocationAddressSchema**](GeolocationAddressSchema.md) |  | [optional] 
**ip** | **str** | IP address of device. | [optional] 
**bt** | [**BtSchema**](BtSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


