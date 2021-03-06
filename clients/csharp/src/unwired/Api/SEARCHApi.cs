/* 
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using unwired.Client;

namespace unwired.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISEARCHApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Forward Geocoding
        /// </summary>
        /// <remarks>
        /// The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>Object</returns>
        Object Search (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null);

        /// <summary>
        /// Forward Geocoding
        /// </summary>
        /// <remarks>
        /// The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SearchWithHttpInfo (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Forward Geocoding
        /// </summary>
        /// <remarks>
        /// The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SearchAsync (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null);

        /// <summary>
        /// Forward Geocoding
        /// </summary>
        /// <remarks>
        /// The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </remarks>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SearchAsyncWithHttpInfo (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SEARCHApi : ISEARCHApi
    {
        private unwired.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SEARCHApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SEARCHApi(String basePath)
        {
            this.Configuration = new unwired.Client.Configuration { BasePath = basePath };

            ExceptionFactory = unwired.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SEARCHApi"/> class
        /// </summary>
        /// <returns></returns>
        public SEARCHApi()
        {
            this.Configuration = unwired.Client.Configuration.Default;

            ExceptionFactory = unwired.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SEARCHApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SEARCHApi(unwired.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = unwired.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = unwired.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public unwired.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public unwired.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Forward Geocoding The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>Object</returns>
        public Object Search (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null)
        {
             ApiResponse<Object> localVarResponse = SearchWithHttpInfo(q, viewbox, limit, acceptLanguage, countrycodes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Forward Geocoding The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SearchWithHttpInfo (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null)
        {
            // verify the required parameter 'q' is set
            if (q == null)
                throw new ApiException(400, "Missing required parameter 'q' when calling SEARCHApi->Search");

            var localVarPath = "/search.php";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (q != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "q", q)); // query parameter
            if (viewbox != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "viewbox", viewbox)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (acceptLanguage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "accept-language", acceptLanguage)); // query parameter
            if (countrycodes != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "countrycodes", countrycodes)); // query parameter

            // authentication (token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "token", this.Configuration.GetApiKeyWithPrefix("token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Forward Geocoding The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SearchAsync (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null)
        {
             ApiResponse<Object> localVarResponse = await SearchAsyncWithHttpInfo(q, viewbox, limit, acceptLanguage, countrycodes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Forward Geocoding The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
        /// </summary>
        /// <exception cref="unwired.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Address to geocode</param>
        /// <param name="viewbox">The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box.  (optional)</param>
        /// <param name="limit">Limit the number of returned results. Default is 10. (optional, default to 10)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="countrycodes">Limit search to a list of countries. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SearchAsyncWithHttpInfo (string q, string viewbox = null, long? limit = null, string acceptLanguage = null, string countrycodes = null)
        {
            // verify the required parameter 'q' is set
            if (q == null)
                throw new ApiException(400, "Missing required parameter 'q' when calling SEARCHApi->Search");

            var localVarPath = "/search.php";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (q != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "q", q)); // query parameter
            if (viewbox != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "viewbox", viewbox)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (acceptLanguage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "accept-language", acceptLanguage)); // query parameter
            if (countrycodes != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "countrycodes", countrycodes)); // query parameter

            // authentication (token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "token", this.Configuration.GetApiKeyWithPrefix("token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
