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


#include "OAIIpf_schema.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAIIpf_schema::OAIIpf_schema(QString json) {
    init();
    this->fromJson(json);
}

OAIIpf_schema::OAIIpf_schema() {
    init();
}

OAIIpf_schema::~OAIIpf_schema() {
    this->cleanup();
}

void
OAIIpf_schema::init() {
}

void
OAIIpf_schema::cleanup() {
}

OAIIpf_schema*
OAIIpf_schema::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
OAIIpf_schema::fromJsonObject(QJsonObject pJson) {
}

QString
OAIIpf_schema::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAIIpf_schema::asJsonObject() {
    QJsonObject obj;

    return obj;
}


bool
OAIIpf_schema::isSet(){
    bool isObjectUpdated = false;
    do{
    }while(false);
    return isObjectUpdated;
}
}
