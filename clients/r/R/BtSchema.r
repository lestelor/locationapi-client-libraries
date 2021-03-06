# Location API
#
# Geolocation, Geocoding and Maps
#
# OpenAPI spec version: 2.0.0
# 
# Generated by: https://openapi-generator.tech


#' BtSchema Class
#'
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
BtSchema <- R6::R6Class(
  'BtSchema',
  public = list(
    initialize = function(){
    },
    toJSON = function() {
      BtSchemaObject <- list()

      BtSchemaObject
    },
    fromJSON = function(BtSchemaJson) {
      BtSchemaObject <- jsonlite::fromJSON(BtSchemaJson)
    },
    toJSONString = function() {
       sprintf(
        '{
        }',
      )
    },
    fromJSONString = function(BtSchemaJson) {
      BtSchemaObject <- jsonlite::fromJSON(BtSchemaJson)
    }
  )
)
