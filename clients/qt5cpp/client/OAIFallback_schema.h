/**
 * Location API
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * OAIFallback_schema.h
 *
 * An array of fallback options to enable or disable.
 */

#ifndef OAIFallback_schema_H_
#define OAIFallback_schema_H_

#include <QJsonObject>


#include "OAIAll_schema.h"
#include "OAIIpf_schema.h"
#include "OAILacf_schema.h"
#include "OAIScf_schema.h"

#include "OAIObject.h"

namespace OpenAPI {

class OAIFallback_schema: public OAIObject {
public:
    OAIFallback_schema();
    OAIFallback_schema(QString json);
    ~OAIFallback_schema();
    void init();
    void cleanup();

    QString asJson () override;
    QJsonObject asJsonObject() override;
    void fromJsonObject(QJsonObject json) override;
    OAIFallback_schema* fromJson(QString jsonString) override;

    OAIAll_schema* getAll();
    void setAll(OAIAll_schema* all);

    OAIIpf_schema* getIpf();
    void setIpf(OAIIpf_schema* ipf);

    OAILacf_schema* getLacf();
    void setLacf(OAILacf_schema* lacf);

    OAIScf_schema* getScf();
    void setScf(OAIScf_schema* scf);


    virtual bool isSet() override;

private:
    OAIAll_schema* all;
    bool m_all_isSet;

    OAIIpf_schema* ipf;
    bool m_ipf_isSet;

    OAILacf_schema* lacf;
    bool m_lacf_isSet;

    OAIScf_schema* scf;
    bool m_scf_isSet;

};

}

#endif /* OAIFallback_schema_H_ */
