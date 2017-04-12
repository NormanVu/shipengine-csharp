# IO.Swagger.Api.AddressValidationApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressValidationValidateAddresses**](AddressValidationApi.md#addressvalidationvalidateaddresses) | **POST** /v1/addresses/validate | 


<a name="addressvalidationvalidateaddresses"></a>
# **AddressValidationValidateAddresses**
> ApiResponseDTOListAddressValidationResponseDTO AddressValidationValidateAddresses (List<AddressDTO> addresses, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddressValidationValidateAddressesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new AddressValidationApi();
            var addresses = new List<AddressDTO>(); // List<AddressDTO> | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ApiResponseDTOListAddressValidationResponseDTO result = apiInstance.AddressValidationValidateAddresses(addresses, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressValidationApi.AddressValidationValidateAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addresses** | [**List&lt;AddressDTO&gt;**](AddressDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ApiResponseDTOListAddressValidationResponseDTO**](ApiResponseDTOListAddressValidationResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
