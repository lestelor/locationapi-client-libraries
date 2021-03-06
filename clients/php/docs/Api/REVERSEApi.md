# unwired\REVERSEApi

All URIs are relative to *https://us1.unwiredlabs.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reverse**](REVERSEApi.md#reverse) | **GET** /reverse.php | Reverse Geocoding


# **reverse**
> object reverse($lat, $lon, $zoom, $accept_language)

Reverse Geocoding

Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: token
$config = unwired\Configuration::getDefaultConfiguration()->setApiKey('token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = unwired\Configuration::getDefaultConfiguration()->setApiKeyPrefix('token', 'Bearer');

$apiInstance = new unwired\Api\REVERSEApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$lat = 17.24; // double | Latitude of the location to generate an address for.
$lon = 74.25; // double | Longitude of the location to generate an address for.
$zoom = 2; // int | Zoom value lies between 0-18. Level of detail required where 0 is country and 18 is house/building
$accept_language = "Empire state building"; // string | Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language=native

try {
    $result = $apiInstance->reverse($lat, $lon, $zoom, $accept_language);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling REVERSEApi->reverse: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lat** | **double**| Latitude of the location to generate an address for. |
 **lon** | **double**| Longitude of the location to generate an address for. |
 **zoom** | **int**| Zoom value lies between 0-18. Level of detail required where 0 is country and 18 is house/building | [optional]
 **accept_language** | **string**| Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native | [optional]

### Return type

**object**

### Authorization

[token](../../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

