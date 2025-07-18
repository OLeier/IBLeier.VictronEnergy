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
    /// A data attribute.
    /// </summary>
    public partial class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf" /> class.
        /// </summary>
        /// <param name="idDataAttribute">Data attribute id.</param>
        /// <param name="code">Data attribute code.</param>
        /// <param name="description">Data attribute description.</param>
        /// <param name="formatWithUnit">Data attribute format string (e.g. \&quot;%.2F V\&quot;).</param>
        /// <param name="dataType">Data attribute type.</param>
        /// <param name="textValue">If the dataType is &#39;enum&#39;, this contains the corresponding text value for that enum.</param>
        /// <param name="instance">The instance to which this attribute data belongs.</param>
        /// <param name="timestamp">The timestamp at which this data was received (UNIX).</param>
        /// <param name="dbusServiceType">Data attribute D-Bus service type.</param>
        /// <param name="dbusPath">Data attribute D-Bus path.</param>
        /// <param name="rawValue">Data attribute last data raw value.</param>
        /// <param name="formattedValue">Data attribute formatted value.</param>
        /// <param name="dataAttributeEnumValues">Possible values for this enum.</param>
        [JsonConstructor]
        public UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf(int idDataAttribute, string code, string description, string formatWithUnit, DataTypeEnum dataType, string textValue, string instance, string timestamp, string dbusServiceType, string dbusPath, string rawValue, string formattedValue, Option<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfDataAttributeEnumValuesInner>?> dataAttributeEnumValues = default)
        {
            IdDataAttribute = idDataAttribute;
            Code = code;
            Description = description;
            FormatWithUnit = formatWithUnit;
            DataType = dataType;
            TextValue = textValue;
            Instance = instance;
            Timestamp = timestamp;
            DbusServiceType = dbusServiceType;
            DbusPath = dbusPath;
            RawValue = rawValue;
            FormattedValue = formattedValue;
            DataAttributeEnumValuesOption = dataAttributeEnumValues;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Data attribute type.
        /// </summary>
        /// <value>Data attribute type.</value>
        public enum DataTypeEnum
        {
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            String = 1,

            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            Float = 2,

            /// <summary>
            /// Enum Enum for value: enum
            /// </summary>
            Enum = 3
        }

        /// <summary>
        /// Returns a <see cref="DataTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static DataTypeEnum DataTypeEnumFromString(string value)
        {
            if (value.Equals("string"))
                return DataTypeEnum.String;

            if (value.Equals("float"))
                return DataTypeEnum.Float;

            if (value.Equals("enum"))
                return DataTypeEnum.Enum;

            throw new NotImplementedException($"Could not convert value to type DataTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="DataTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataTypeEnum? DataTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("string"))
                return DataTypeEnum.String;

            if (value.Equals("float"))
                return DataTypeEnum.Float;

            if (value.Equals("enum"))
                return DataTypeEnum.Enum;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="DataTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string DataTypeEnumToJsonValue(DataTypeEnum value)
        {
            if (value == DataTypeEnum.String)
                return "string";

            if (value == DataTypeEnum.Float)
                return "float";

            if (value == DataTypeEnum.Enum)
                return "enum";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Data attribute type.
        /// </summary>
        /// <value>Data attribute type.</value>
        [JsonPropertyName("dataType")]
        public DataTypeEnum DataType { get; set; }

        /// <summary>
        /// Data attribute id.
        /// </summary>
        /// <value>Data attribute id.</value>
        [JsonPropertyName("idDataAttribute")]
        public int IdDataAttribute { get; set; }

        /// <summary>
        /// Data attribute code.
        /// </summary>
        /// <value>Data attribute code.</value>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Data attribute description.
        /// </summary>
        /// <value>Data attribute description.</value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Data attribute format string (e.g. \&quot;%.2F V\&quot;).
        /// </summary>
        /// <value>Data attribute format string (e.g. \&quot;%.2F V\&quot;).</value>
        [JsonPropertyName("formatWithUnit")]
        public string FormatWithUnit { get; set; }

        /// <summary>
        /// If the dataType is &#39;enum&#39;, this contains the corresponding text value for that enum.
        /// </summary>
        /// <value>If the dataType is &#39;enum&#39;, this contains the corresponding text value for that enum.</value>
        [JsonPropertyName("textValue")]
        public string TextValue { get; set; }

        /// <summary>
        /// The instance to which this attribute data belongs.
        /// </summary>
        /// <value>The instance to which this attribute data belongs.</value>
        [JsonPropertyName("instance")]
        public string Instance { get; set; }

        /// <summary>
        /// The timestamp at which this data was received (UNIX).
        /// </summary>
        /// <value>The timestamp at which this data was received (UNIX).</value>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// Data attribute D-Bus service type.
        /// </summary>
        /// <value>Data attribute D-Bus service type.</value>
        [JsonPropertyName("dbusServiceType")]
        public string DbusServiceType { get; set; }

        /// <summary>
        /// Data attribute D-Bus path.
        /// </summary>
        /// <value>Data attribute D-Bus path.</value>
        [JsonPropertyName("dbusPath")]
        public string DbusPath { get; set; }

        /// <summary>
        /// Data attribute last data raw value.
        /// </summary>
        /// <value>Data attribute last data raw value.</value>
        [JsonPropertyName("rawValue")]
        public string RawValue { get; set; }

        /// <summary>
        /// Data attribute formatted value.
        /// </summary>
        /// <value>Data attribute formatted value.</value>
        [JsonPropertyName("formattedValue")]
        public string FormattedValue { get; set; }

        /// <summary>
        /// Used to track the state of DataAttributeEnumValues
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfDataAttributeEnumValuesInner>?> DataAttributeEnumValuesOption { get; private set; }

        /// <summary>
        /// Possible values for this enum.
        /// </summary>
        /// <value>Possible values for this enum.</value>
        [JsonPropertyName("dataAttributeEnumValues")]
        public List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfDataAttributeEnumValuesInner>? DataAttributeEnumValues { get { return this.DataAttributeEnumValuesOption; } set { this.DataAttributeEnumValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf {\n");
            sb.Append("  IdDataAttribute: ").Append(IdDataAttribute).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FormatWithUnit: ").Append(FormatWithUnit).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  TextValue: ").Append(TextValue).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  DbusServiceType: ").Append(DbusServiceType).Append("\n");
            sb.Append("  DbusPath: ").Append(DbusPath).Append("\n");
            sb.Append("  RawValue: ").Append(RawValue).Append("\n");
            sb.Append("  FormattedValue: ").Append(FormattedValue).Append("\n");
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
    /// A Json converter for type <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf" />
    /// </summary>
    public class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfJsonConverter : JsonConverter<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> idDataAttribute = default;
            Option<string?> code = default;
            Option<string?> description = default;
            Option<string?> formatWithUnit = default;
            Option<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataTypeEnum?> dataType = default;
            Option<string?> textValue = default;
            Option<string?> instance = default;
            Option<string?> timestamp = default;
            Option<string?> dbusServiceType = default;
            Option<string?> dbusPath = default;
            Option<string?> rawValue = default;
            Option<string?> formattedValue = default;
            Option<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfDataAttributeEnumValuesInner>?> dataAttributeEnumValues = default;

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
                        case "idDataAttribute":
                            idDataAttribute = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formatWithUnit":
                            formatWithUnit = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dataType":
                            string? dataTypeRawValue = utf8JsonReader.GetString();
                            if (dataTypeRawValue != null)
                                dataType = new Option<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataTypeEnum?>(UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataTypeEnumFromStringOrDefault(dataTypeRawValue));
                            break;
                        case "textValue":
                            textValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "instance":
                            instance = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "timestamp":
                            timestamp = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dbusServiceType":
                            dbusServiceType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dbusPath":
                            dbusPath = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "rawValue":
                            rawValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formattedValue":
                            formattedValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dataAttributeEnumValues":
                            dataAttributeEnumValues = new Option<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfDataAttributeEnumValuesInner>?>(JsonSerializer.Deserialize<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOfDataAttributeEnumValuesInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!idDataAttribute.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(idDataAttribute));

            if (!code.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(code));

            if (!description.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(description));

            if (!formatWithUnit.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(formatWithUnit));

            if (!dataType.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(dataType));

            if (!textValue.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(textValue));

            if (!instance.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(instance));

            if (!timestamp.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(timestamp));

            if (!dbusServiceType.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(dbusServiceType));

            if (!dbusPath.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(dbusPath));

            if (!rawValue.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(rawValue));

            if (!formattedValue.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.", nameof(formattedValue));

            if (idDataAttribute.IsSet && idDataAttribute.Value == null)
                throw new ArgumentNullException(nameof(idDataAttribute), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (formatWithUnit.IsSet && formatWithUnit.Value == null)
                throw new ArgumentNullException(nameof(formatWithUnit), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (dataType.IsSet && dataType.Value == null)
                throw new ArgumentNullException(nameof(dataType), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (textValue.IsSet && textValue.Value == null)
                throw new ArgumentNullException(nameof(textValue), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (instance.IsSet && instance.Value == null)
                throw new ArgumentNullException(nameof(instance), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (timestamp.IsSet && timestamp.Value == null)
                throw new ArgumentNullException(nameof(timestamp), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (dbusServiceType.IsSet && dbusServiceType.Value == null)
                throw new ArgumentNullException(nameof(dbusServiceType), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (dbusPath.IsSet && dbusPath.Value == null)
                throw new ArgumentNullException(nameof(dbusPath), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (rawValue.IsSet && rawValue.Value == null)
                throw new ArgumentNullException(nameof(rawValue), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (formattedValue.IsSet && formattedValue.Value == null)
                throw new ArgumentNullException(nameof(formattedValue), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (dataAttributeEnumValues.IsSet && dataAttributeEnumValues.Value == null)
                throw new ArgumentNullException(nameof(dataAttributeEnumValues), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            return new UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf(idDataAttribute.Value!.Value!, code.Value!, description.Value!, formatWithUnit.Value!, dataType.Value!.Value!, textValue.Value!, instance.Value!, timestamp.Value!, dbusServiceType.Value!, dbusPath.Value!, rawValue.Value!, formattedValue.Value!, dataAttributeEnumValues);
        }

        /// <summary>
        /// Serializes a <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Code == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Code), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Description == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Description), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.FormatWithUnit == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.FormatWithUnit), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.TextValue == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.TextValue), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Instance == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Instance), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Timestamp == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Timestamp), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DbusServiceType == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DbusServiceType), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DbusPath == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DbusPath), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.RawValue == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.RawValue), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.FormattedValue == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.FormattedValue), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataAttributeEnumValuesOption.IsSet && usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataAttributeEnumValues == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataAttributeEnumValues), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.");

            writer.WriteNumber("idDataAttribute", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.IdDataAttribute);

            writer.WriteString("code", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Code);

            writer.WriteString("description", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Description);

            writer.WriteString("formatWithUnit", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.FormatWithUnit);

            var dataTypeRawValue = UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataTypeEnumToJsonValue(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataType);
            writer.WriteString("dataType", dataTypeRawValue);
            writer.WriteString("textValue", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.TextValue);

            writer.WriteString("instance", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Instance);

            writer.WriteString("timestamp", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.Timestamp);

            writer.WriteString("dbusServiceType", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DbusServiceType);

            writer.WriteString("dbusPath", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DbusPath);

            writer.WriteString("rawValue", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.RawValue);

            writer.WriteString("formattedValue", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.FormattedValue);

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataAttributeEnumValuesOption.IsSet)
            {
                writer.WritePropertyName("dataAttributeEnumValues");
                JsonSerializer.Serialize(writer, usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf.DataAttributeEnumValues, jsonSerializerOptions);
            }
        }
    }
}
