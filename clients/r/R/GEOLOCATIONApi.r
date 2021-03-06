# Location API
#
# Geolocation, Geocoding and Maps
#
# OpenAPI spec version: 2.0.0
# 
# Generated by: https://openapi-generator.tech

#' @title GEOLOCATION operations
#' @description unwired.GEOLOCATION
#'
#' @field path Stores url path of the request.
#' @field apiClient Handles the client-server communication.
#' @field userAgent Set the user agent of the request.
#'
#' @importFrom R6 R6Class
#'
#' @section Methods:
#' \describe{
#'
#' geolocation Geolocation
#'
#' }
#'
#' @export
GEOLOCATIONApi <- R6::R6Class(
  'GEOLOCATIONApi',
  public = list(
    userAgent = "OpenAPI-Generator/1.0.0/r",
    apiClient = NULL,
    initialize = function(apiClient){
      if (!missing(apiClient)) {
        self$apiClient <- apiClient
      }
      else {
        self$apiClient <- ApiClient$new()
      }
    },
    geolocation = function(geolocation_schema, ...){
      args <- list(...)
      queryParams <- list()
      headerParams <- character()

      if (!missing(`geolocation_schema`)) {
        body <- `geolocation_schema`$toJSONString()
      } else {
        body <- NULL
      }

      urlPath <- "/process.php"
      resp <- self$apiClient$callApi(url = paste0(self$apiClient$basePath, urlPath),
                                 method = "POST",
                                 queryParams = queryParams,
                                 headerParams = headerParams,
                                 body = body,
                                 ...)
      
      if (httr::status_code(resp) >= 200 && httr::status_code(resp) <= 299) {
        returnObject <- object$new()
        result <- returnObject$fromJSON(httr::content(resp, "text", encoding = "UTF-8"))
        Response$new(returnObject, resp)
      } else if (httr::status_code(resp) >= 400 && httr::status_code(resp) <= 499) {
        Response$new("API client error", resp)
      } else if (httr::status_code(resp) >= 500 && httr::status_code(resp) <= 599) {
        Response$new("API server error", resp)
      }

    }
  )
)
