=begin
#Location API

#Geolocation, Geocoding and Maps

OpenAPI spec version: 2.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 3.3.4

=end

require 'date'

module unwiredClient
  class BtSchema
    
    0 = 0.freeze
    1 = 1.freeze
    2 = 2.freeze

    # Builds the enum from string
    # @param [String] The enum value in the form of the string
    # @return [String] The enum value
    def build_from_hash(value)
      constantValues = BtSchema.constants.select { |c| BtSchema::const_get(c) == value }
      raise "Invalid ENUM value #{value} for class #BtSchema" if constantValues.empty?
      value
    end
  end
end