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
    /// Site summary data.
    /// </summary>
    public partial class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1" /> class.
        /// </summary>
        /// <param name="code">Summary data code.</param>
        /// <param name="description">Summary data description.</param>
        /// <param name="formattedValue">Summary data formatted value.</param>
        /// <param name="formatWithUnit">Summary data format string (e.g. \&quot;%.2F V\&quot;).</param>
        /// <param name="dataAttributes">dataAttributes</param>
        /// <param name="rawValue">Summary data last raw value.</param>
        /// <param name="textValue">If the dataType is &#39;enum&#39;, this contains the corresponding text value for that enum.</param>
        /// <param name="idDataAttribute">Corresponding data attribute id.</param>
        [JsonConstructor]
        public UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1(string code, string description, string formattedValue, string formatWithUnit, List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1DataAttributesInner> dataAttributes, decimal? rawValue = default, string? textValue = default, int? idDataAttribute = default)
        {
            Code = code;
            Description = description;
            FormattedValue = formattedValue;
            FormatWithUnit = formatWithUnit;
            DataAttributes = dataAttributes;
            RawValue = rawValue;
            TextValue = textValue;
            IdDataAttribute = idDataAttribute;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Summary data code.
        /// </summary>
        /// <value>Summary data code.</value>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Summary data description.
        /// </summary>
        /// <value>Summary data description.</value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Summary data formatted value.
        /// </summary>
        /// <value>Summary data formatted value.</value>
        [JsonPropertyName("formattedValue")]
        public string FormattedValue { get; set; }

        /// <summary>
        /// Summary data format string (e.g. \&quot;%.2F V\&quot;).
        /// </summary>
        /// <value>Summary data format string (e.g. \&quot;%.2F V\&quot;).</value>
        [JsonPropertyName("formatWithUnit")]
        public string FormatWithUnit { get; set; }

        /// <summary>
        /// Gets or Sets DataAttributes
        /// </summary>
        [JsonPropertyName("dataAttributes")]
        public List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1DataAttributesInner> DataAttributes { get; set; }

        /// <summary>
        /// Summary data last raw value.
        /// </summary>
        /// <value>Summary data last raw value.</value>
        [JsonPropertyName("rawValue")]
        public decimal? RawValue { get; set; }

        /// <summary>
        /// If the dataType is &#39;enum&#39;, this contains the corresponding text value for that enum.
        /// </summary>
        /// <value>If the dataType is &#39;enum&#39;, this contains the corresponding text value for that enum.</value>
        [JsonPropertyName("textValue")]
        public string? TextValue { get; set; }

        /// <summary>
        /// Corresponding data attribute id.
        /// </summary>
        /// <value>Corresponding data attribute id.</value>
        [JsonPropertyName("idDataAttribute")]
        public int? IdDataAttribute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1 {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FormattedValue: ").Append(FormattedValue).Append("\n");
            sb.Append("  FormatWithUnit: ").Append(FormatWithUnit).Append("\n");
            sb.Append("  DataAttributes: ").Append(DataAttributes).Append("\n");
            sb.Append("  RawValue: ").Append(RawValue).Append("\n");
            sb.Append("  TextValue: ").Append(TextValue).Append("\n");
            sb.Append("  IdDataAttribute: ").Append(IdDataAttribute).Append("\n");
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
    /// A Json converter for type <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1" />
    /// </summary>
    public class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1JsonConverter : JsonConverter<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> code = default;
            Option<string?> description = default;
            Option<string?> formattedValue = default;
            Option<string?> formatWithUnit = default;
            Option<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1DataAttributesInner>?> dataAttributes = default;
            Option<decimal?> rawValue = default;
            Option<string?> textValue = default;
            Option<int?> idDataAttribute = default;

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
                        case "formattedValue":
                            formattedValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "formatWithUnit":
                            formatWithUnit = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dataAttributes":
                            dataAttributes = new Option<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1DataAttributesInner>?>(JsonSerializer.Deserialize<List<UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1DataAttributesInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "rawValue":
                            rawValue = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "textValue":
                            textValue = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "idDataAttribute":
                            idDataAttribute = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!code.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(code));

            if (!description.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(description));

            if (!formattedValue.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(formattedValue));

            if (!formatWithUnit.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(formatWithUnit));

            if (!dataAttributes.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(dataAttributes));

            if (!rawValue.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(rawValue));

            if (!textValue.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(textValue));

            if (!idDataAttribute.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.", nameof(idDataAttribute));

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (formattedValue.IsSet && formattedValue.Value == null)
                throw new ArgumentNullException(nameof(formattedValue), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (formatWithUnit.IsSet && formatWithUnit.Value == null)
                throw new ArgumentNullException(nameof(formatWithUnit), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (dataAttributes.IsSet && dataAttributes.Value == null)
                throw new ArgumentNullException(nameof(dataAttributes), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            return new UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1(code.Value!, description.Value!, formattedValue.Value!, formatWithUnit.Value!, dataAttributes.Value!, rawValue.Value!, textValue.Value!, idDataAttribute.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1 usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1 usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.Code == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.Code), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.Description == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.Description), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.FormattedValue == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.FormattedValue), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.FormatWithUnit == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.FormatWithUnit), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.DataAttributes == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.DataAttributes), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.");

            writer.WriteString("code", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.Code);

            writer.WriteString("description", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.Description);

            writer.WriteString("formattedValue", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.FormattedValue);

            writer.WriteString("formatWithUnit", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.FormatWithUnit);

            writer.WritePropertyName("dataAttributes");
            JsonSerializer.Serialize(writer, usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.DataAttributes, jsonSerializerOptions);
            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.RawValue != null)
                writer.WriteNumber("rawValue", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.RawValue.Value);
            else
                writer.WriteNull("rawValue");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.TextValue != null)
                writer.WriteString("textValue", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.TextValue);
            else
                writer.WriteNull("textValue");

            if (usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.IdDataAttribute != null)
                writer.WriteNumber("idDataAttribute", usersIdUserInstallations200ResponseRecordsInnerExtendedInnerAnyOf1.IdDataAttribute.Value);
            else
                writer.WriteNull("idDataAttribute");
        }
    }
}
