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
    /// Meta data for data attribute with this key.
    /// </summary>
    public partial class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue" /> class.
        /// </summary>
        /// <param name="code">Data attribute code.</param>
        /// <param name="description">Data attribute description.</param>
        /// <param name="formatWithUnit">Data attribute format with both value and unit.</param>
        /// <param name="formatWithValueOnly">Data attribute format with only the value.</param>
        [JsonConstructor]
        public InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue(string code, string description, string formatWithUnit, Option<string?> formatWithValueOnly = default)
        {
            Code = code;
            Description = description;
            FormatWithUnit = formatWithUnit;
            FormatWithValueOnlyOption = formatWithValueOnly;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Data attribute format with both value and unit.
        /// </summary>
        /// <value>Data attribute format with both value and unit.</value>
        [JsonPropertyName("formatWithUnit")]
        public string FormatWithUnit { get; set; }

        /// <summary>
        /// Used to track the state of FormatWithValueOnly
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FormatWithValueOnlyOption { get; private set; }

        /// <summary>
        /// Data attribute format with only the value.
        /// </summary>
        /// <value>Data attribute format with only the value.</value>
        [JsonPropertyName("formatWithValueOnly")]
        public string? FormatWithValueOnly { get { return this.FormatWithValueOnlyOption; } set { this.FormatWithValueOnlyOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FormatWithUnit: ").Append(FormatWithUnit).Append("\n");
            sb.Append("  FormatWithValueOnly: ").Append(FormatWithValueOnly).Append("\n");
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
    /// A Json converter for type <see cref="InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue" />
    /// </summary>
    public class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValueJsonConverter : JsonConverter<InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> code = default;
            Option<string?> description = default;
            Option<string?> formatWithUnit = default;
            Option<string?> formatWithValueOnly = default;

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
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formatWithUnit":
                            formatWithUnit = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formatWithValueOnly":
                            formatWithValueOnly = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!code.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.", nameof(code));

            if (!description.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.", nameof(description));

            if (!formatWithUnit.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.", nameof(formatWithUnit));

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            if (formatWithUnit.IsSet && formatWithUnit.Value == null)
                throw new ArgumentNullException(nameof(formatWithUnit), "Property is not nullable for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            if (formatWithValueOnly.IsSet && formatWithValueOnly.Value == null)
                throw new ArgumentNullException(nameof(formatWithValueOnly), "Property is not nullable for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            return new InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue(code.Value!, description.Value!, formatWithUnit.Value!, formatWithValueOnly);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.Code == null)
                throw new ArgumentNullException(nameof(installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.Code), "Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            if (installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.Description == null)
                throw new ArgumentNullException(nameof(installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.Description), "Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            if (installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithUnit == null)
                throw new ArgumentNullException(nameof(installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithUnit), "Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            if (installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithValueOnlyOption.IsSet && installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithValueOnly == null)
                throw new ArgumentNullException(nameof(installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithValueOnly), "Property is required for class InstallationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.");

            writer.WriteString("code", installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.Code);

            writer.WriteString("description", installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.Description);

            writer.WriteString("formatWithUnit", installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithUnit);

            if (installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithValueOnlyOption.IsSet)
                writer.WriteString("formatWithValueOnly", installationsIdSiteWidgetsGraph200ResponseRecordsMetaValue.FormatWithValueOnly);
        }
    }
}
