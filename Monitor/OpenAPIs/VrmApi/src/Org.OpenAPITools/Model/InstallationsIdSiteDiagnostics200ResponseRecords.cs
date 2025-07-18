// <auto-generated>
/*
 * VRM API
 *
 * ## Introduction This document provides a brief overview of some of the available endpoints and their parameters. The API is a REST API, accepting JSON as request body. You can use the try-it tool to play around with it, or use software like Postman.  ## Authentication Most endpoints require authentication, using a JWT token. This token should be placed in the `x-authorization` field in the HTTP header. There are two types of tokens. - Bearer token. Uses the `Bearer <token_value>` format. This is used when logging in to VRM, for example. Can be retrieved from [/auth/login](/operations/auth/login) or [/auth/loginAsDemo](/operations/auth/loginAsDemo). - Access token. Uses the `Token <token_value>` format. This is commonly used for third party applications using the VRM API. Can be created using [/users/{idUser}/accesstokens/create](/operations/users/idUser/accesstokens/create).  ## Rate limiting Most endpoints are by default rate limited with a rolling window of max 200 requests, where every 0.33 seconds a request gets removed from the rolling window. (so on average maximum of 3 requests per second won't get rate limited). There are different types of ratelimiting in VRM. If you receive a 429 with a JSON response, you can check the Retry-After response header to check the amount of seconds you have to wait until retrying.  ## WARNING & DISCLAIMER Whilst publicly available, Victron Energy does not offer support to professional customers or end-users that implement features using the here documented functionality, except in really specific situations (i.e such as a special arrangement with a large OEM customer).  The recommended method for support on the VRM API is to use the Modifications section on Victron Community. This space is frequently visited by many people using the API, and other methods of integrating with Victron products. Direct company support is only offered on a limited basis via your Victron representative.
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Fetched logging data.
    /// </summary>
    public partial class InstallationsIdSiteDiagnostics200ResponseRecords : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationsIdSiteDiagnostics200ResponseRecords" /> class.
        /// </summary>
        /// <param name="idSite">Installation id.</param>
        /// <param name="timestamp">Timestamp at which this data was logged.</param>
        /// <param name="device">Logging device name.</param>
        /// <param name="instance">Log data instance.</param>
        /// <param name="idDataAttribute">Log data attribute id.</param>
        /// <param name="description">Log data description.</param>
        /// <param name="formatWithUnit">Data attribute string format.</param>
        /// <param name="code">Data attribute code.</param>
        /// <param name="bitmask">1 if the data attribute is a bitmask, else 0.</param>
        /// <param name="formattedValue">Log data value formatted as a string.</param>
        /// <param name="rawValue">rawValue</param>
        /// <param name="id">Log data id.</param>
        /// <param name="dbusServiceType">Device DBus Service type.</param>
        /// <param name="dbusPath">Device DBus path.</param>
        /// <param name="dataAttributeEnumValues">Data attribute enum values, only for data attributes of type enum.</param>
        [JsonConstructor]
        public InstallationsIdSiteDiagnostics200ResponseRecords(int idSite, int timestamp, string device, int instance, int idDataAttribute, string description, string formatWithUnit, string code, int bitmask, string formattedValue, InstallationsIdSiteDiagnostics200ResponseRecordsRawValue rawValue, int id, string? dbusServiceType = default, string? dbusPath = default, Option<List<InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner>?> dataAttributeEnumValues = default)
        {
            IdSite = idSite;
            Timestamp = timestamp;
            Device = device;
            Instance = instance;
            IdDataAttribute = idDataAttribute;
            Description = description;
            FormatWithUnit = formatWithUnit;
            Code = code;
            Bitmask = bitmask;
            FormattedValue = formattedValue;
            RawValue = rawValue;
            Id = id;
            DbusServiceType = dbusServiceType;
            DbusPath = dbusPath;
            DataAttributeEnumValuesOption = dataAttributeEnumValues;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Installation id.
        /// </summary>
        /// <value>Installation id.</value>
        [JsonPropertyName("idSite")]
        public int IdSite { get; set; }

        /// <summary>
        /// Timestamp at which this data was logged.
        /// </summary>
        /// <value>Timestamp at which this data was logged.</value>
        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        /// <summary>
        /// Logging device name.
        /// </summary>
        /// <value>Logging device name.</value>
        [JsonPropertyName("Device")]
        public string Device { get; set; }

        /// <summary>
        /// Log data instance.
        /// </summary>
        /// <value>Log data instance.</value>
        [JsonPropertyName("instance")]
        public int Instance { get; set; }

        /// <summary>
        /// Log data attribute id.
        /// </summary>
        /// <value>Log data attribute id.</value>
        [JsonPropertyName("idDataAttribute")]
        public int IdDataAttribute { get; set; }

        /// <summary>
        /// Log data description.
        /// </summary>
        /// <value>Log data description.</value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Data attribute string format.
        /// </summary>
        /// <value>Data attribute string format.</value>
        [JsonPropertyName("formatWithUnit")]
        public string FormatWithUnit { get; set; }

        /// <summary>
        /// Data attribute code.
        /// </summary>
        /// <value>Data attribute code.</value>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 1 if the data attribute is a bitmask, else 0.
        /// </summary>
        /// <value>1 if the data attribute is a bitmask, else 0.</value>
        [JsonPropertyName("bitmask")]
        public int Bitmask { get; set; }

        /// <summary>
        /// Log data value formatted as a string.
        /// </summary>
        /// <value>Log data value formatted as a string.</value>
        [JsonPropertyName("formattedValue")]
        public string FormattedValue { get; set; }

        /// <summary>
        /// Gets or Sets RawValue
        /// </summary>
        [JsonPropertyName("rawValue")]
        public InstallationsIdSiteDiagnostics200ResponseRecordsRawValue RawValue { get; set; }

        /// <summary>
        /// Log data id.
        /// </summary>
        /// <value>Log data id.</value>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Device DBus Service type.
        /// </summary>
        /// <value>Device DBus Service type.</value>
        [JsonPropertyName("dbusServiceType")]
        public string? DbusServiceType { get; set; }

        /// <summary>
        /// Device DBus path.
        /// </summary>
        /// <value>Device DBus path.</value>
        [JsonPropertyName("dbusPath")]
        public string? DbusPath { get; set; }

        /// <summary>
        /// Used to track the state of DataAttributeEnumValues
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner>?> DataAttributeEnumValuesOption { get; private set; }

        /// <summary>
        /// Data attribute enum values, only for data attributes of type enum.
        /// </summary>
        /// <value>Data attribute enum values, only for data attributes of type enum.</value>
        [JsonPropertyName("dataAttributeEnumValues")]
        public List<InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner>? DataAttributeEnumValues { get { return this.DataAttributeEnumValuesOption; } set { this.DataAttributeEnumValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationsIdSiteDiagnostics200ResponseRecords {\n");
            sb.Append("  IdSite: ").Append(IdSite).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  IdDataAttribute: ").Append(IdDataAttribute).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FormatWithUnit: ").Append(FormatWithUnit).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Bitmask: ").Append(Bitmask).Append("\n");
            sb.Append("  FormattedValue: ").Append(FormattedValue).Append("\n");
            sb.Append("  RawValue: ").Append(RawValue).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DbusServiceType: ").Append(DbusServiceType).Append("\n");
            sb.Append("  DbusPath: ").Append(DbusPath).Append("\n");
            sb.Append("  DataAttributeEnumValues: ").Append(DataAttributeEnumValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="InstallationsIdSiteDiagnostics200ResponseRecords" />
    /// </summary>
    public class InstallationsIdSiteDiagnostics200ResponseRecordsJsonConverter : JsonConverter<InstallationsIdSiteDiagnostics200ResponseRecords>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallationsIdSiteDiagnostics200ResponseRecords" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationsIdSiteDiagnostics200ResponseRecords Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> idSite = default;
            Option<int?> timestamp = default;
            Option<string?> device = default;
            Option<int?> instance = default;
            Option<int?> idDataAttribute = default;
            Option<string?> description = default;
            Option<string?> formatWithUnit = default;
            Option<string?> code = default;
            Option<int?> bitmask = default;
            Option<string?> formattedValue = default;
            Option<InstallationsIdSiteDiagnostics200ResponseRecordsRawValue?> rawValue = default;
            Option<int?> id = default;
            Option<string?> dbusServiceType = default;
            Option<string?> dbusPath = default;
            Option<List<InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner>?> dataAttributeEnumValues = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "idSite":
                            idSite = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "timestamp":
                            timestamp = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "Device":
                            device = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "instance":
                            instance = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "idDataAttribute":
                            idDataAttribute = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formatWithUnit":
                            formatWithUnit = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "bitmask":
                            bitmask = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "formattedValue":
                            formattedValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "rawValue":
                            rawValue = new Option<InstallationsIdSiteDiagnostics200ResponseRecordsRawValue?>(JsonSerializer.Deserialize<InstallationsIdSiteDiagnostics200ResponseRecordsRawValue>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "dbusServiceType":
                            dbusServiceType = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "dbusPath":
                            dbusPath = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "dataAttributeEnumValues":
                            dataAttributeEnumValues = new Option<List<InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner>?>(JsonSerializer.Deserialize<List<InstallationsIdSiteDiagnostics200ResponseRecordsDataAttributeEnumValuesInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!idSite.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(idSite));

            if (!timestamp.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(timestamp));

            if (!device.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(device));

            if (!instance.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(instance));

            if (!idDataAttribute.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(idDataAttribute));

            if (!description.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(description));

            if (!formatWithUnit.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(formatWithUnit));

            if (!code.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(code));

            if (!bitmask.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(bitmask));

            if (!formattedValue.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(formattedValue));

            if (!rawValue.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(rawValue));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(id));

            if (!dbusServiceType.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(dbusServiceType));

            if (!dbusPath.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.", nameof(dbusPath));

            if (idSite.IsSet && idSite.Value == null)
                throw new ArgumentNullException(nameof(idSite), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (timestamp.IsSet && timestamp.Value == null)
                throw new ArgumentNullException(nameof(timestamp), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (device.IsSet && device.Value == null)
                throw new ArgumentNullException(nameof(device), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (instance.IsSet && instance.Value == null)
                throw new ArgumentNullException(nameof(instance), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (idDataAttribute.IsSet && idDataAttribute.Value == null)
                throw new ArgumentNullException(nameof(idDataAttribute), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (formatWithUnit.IsSet && formatWithUnit.Value == null)
                throw new ArgumentNullException(nameof(formatWithUnit), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (bitmask.IsSet && bitmask.Value == null)
                throw new ArgumentNullException(nameof(bitmask), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (formattedValue.IsSet && formattedValue.Value == null)
                throw new ArgumentNullException(nameof(formattedValue), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (rawValue.IsSet && rawValue.Value == null)
                throw new ArgumentNullException(nameof(rawValue), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (dataAttributeEnumValues.IsSet && dataAttributeEnumValues.Value == null)
                throw new ArgumentNullException(nameof(dataAttributeEnumValues), "Property is not nullable for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            return new InstallationsIdSiteDiagnostics200ResponseRecords(idSite.Value!.Value!, timestamp.Value!.Value!, device.Value!, instance.Value!.Value!, idDataAttribute.Value!.Value!, description.Value!, formatWithUnit.Value!, code.Value!, bitmask.Value!.Value!, formattedValue.Value!, rawValue.Value!, id.Value!.Value!, dbusServiceType.Value!, dbusPath.Value!, dataAttributeEnumValues);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationsIdSiteDiagnostics200ResponseRecords" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteDiagnostics200ResponseRecords"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationsIdSiteDiagnostics200ResponseRecords installationsIdSiteDiagnostics200ResponseRecords, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installationsIdSiteDiagnostics200ResponseRecords, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationsIdSiteDiagnostics200ResponseRecords" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteDiagnostics200ResponseRecords"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationsIdSiteDiagnostics200ResponseRecords installationsIdSiteDiagnostics200ResponseRecords, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installationsIdSiteDiagnostics200ResponseRecords.Device == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.Device), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (installationsIdSiteDiagnostics200ResponseRecords.Description == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.Description), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (installationsIdSiteDiagnostics200ResponseRecords.FormatWithUnit == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.FormatWithUnit), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (installationsIdSiteDiagnostics200ResponseRecords.Code == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.Code), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (installationsIdSiteDiagnostics200ResponseRecords.FormattedValue == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.FormattedValue), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (installationsIdSiteDiagnostics200ResponseRecords.RawValue == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.RawValue), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            if (installationsIdSiteDiagnostics200ResponseRecords.DataAttributeEnumValuesOption.IsSet && installationsIdSiteDiagnostics200ResponseRecords.DataAttributeEnumValues == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDiagnostics200ResponseRecords.DataAttributeEnumValues), "Property is required for class InstallationsIdSiteDiagnostics200ResponseRecords.");

            writer.WriteNumber("idSite", installationsIdSiteDiagnostics200ResponseRecords.IdSite);

            writer.WriteNumber("timestamp", installationsIdSiteDiagnostics200ResponseRecords.Timestamp);

            writer.WriteString("Device", installationsIdSiteDiagnostics200ResponseRecords.Device);

            writer.WriteNumber("instance", installationsIdSiteDiagnostics200ResponseRecords.Instance);

            writer.WriteNumber("idDataAttribute", installationsIdSiteDiagnostics200ResponseRecords.IdDataAttribute);

            writer.WriteString("description", installationsIdSiteDiagnostics200ResponseRecords.Description);

            writer.WriteString("formatWithUnit", installationsIdSiteDiagnostics200ResponseRecords.FormatWithUnit);

            writer.WriteString("code", installationsIdSiteDiagnostics200ResponseRecords.Code);

            writer.WriteNumber("bitmask", installationsIdSiteDiagnostics200ResponseRecords.Bitmask);

            writer.WriteString("formattedValue", installationsIdSiteDiagnostics200ResponseRecords.FormattedValue);

            writer.WritePropertyName("rawValue");
            JsonSerializer.Serialize(writer, installationsIdSiteDiagnostics200ResponseRecords.RawValue, jsonSerializerOptions);
            writer.WriteNumber("id", installationsIdSiteDiagnostics200ResponseRecords.Id);

            if (installationsIdSiteDiagnostics200ResponseRecords.DbusServiceType != null)
                writer.WriteString("dbusServiceType", installationsIdSiteDiagnostics200ResponseRecords.DbusServiceType);
            else
                writer.WriteNull("dbusServiceType");

            if (installationsIdSiteDiagnostics200ResponseRecords.DbusPath != null)
                writer.WriteString("dbusPath", installationsIdSiteDiagnostics200ResponseRecords.DbusPath);
            else
                writer.WriteNull("dbusPath");

            if (installationsIdSiteDiagnostics200ResponseRecords.DataAttributeEnumValuesOption.IsSet)
            {
                writer.WritePropertyName("dataAttributeEnumValues");
                JsonSerializer.Serialize(writer, installationsIdSiteDiagnostics200ResponseRecords.DataAttributeEnumValues, jsonSerializerOptions);
            }
        }
    }
}
