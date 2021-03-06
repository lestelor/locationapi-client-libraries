/*
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * API version: 2.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package unwired

type TimezoneResponseSchema struct {
	// If the request is successful, ok is returned. Otherwise error is returned
	Status string `json:"status,omitempty"`
	// Balance left in the account
	Balance int64 `json:"balance,omitempty"`
	Timezone TimezoneSchema `json:"timezone,omitempty"`
}
