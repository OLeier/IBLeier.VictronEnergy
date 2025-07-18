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
    /// State changes for data attribute with this key.
    /// </summary>
    public partial class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue" /> class.
        /// </summary>
        /// <param name="var0">State value during this timeframe.</param>
        /// <param name="var1">Start of timeframe as a unix timestamp.</param>
        /// <param name="var2">End of timeframe as a unix timestamp.</param>
        [JsonConstructor]
        public InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue(string var0, int var1, int var2)
        {
            Var0 = var0;
            Var1 = var1;
            Var2 = var2;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// State value during this timeframe.
        /// </summary>
        /// <value>State value during this timeframe.</value>
        [JsonPropertyName("0")]
        public string Var0 { get; set; }

        /// <summary>
        /// Start of timeframe as a unix timestamp.
        /// </summary>
        /// <value>Start of timeframe as a unix timestamp.</value>
        [JsonPropertyName("1")]
        public int Var1 { get; set; }

        /// <summary>
        /// End of timeframe as a unix timestamp.
        /// </summary>
        /// <value>End of timeframe as a unix timestamp.</value>
        [JsonPropertyName("2")]
        public int Var2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue {\n");
            sb.Append("  Var0: ").Append(Var0).Append("\n");
            sb.Append("  Var1: ").Append(Var1).Append("\n");
            sb.Append("  Var2: ").Append(Var2).Append("\n");
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
    /// A Json converter for type <see cref="InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue" />
    /// </summary>
    public class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValueJsonConverter : JsonConverter<InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> var0 = default;
            Option<int?> var1 = default;
            Option<int?> var2 = default;

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
                        case "0":
                            var0 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "1":
                            var1 = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "2":
                            var2 = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!var0.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.", nameof(var0));

            if (!var1.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.", nameof(var1));

            if (!var2.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.", nameof(var2));

            if (var0.IsSet && var0.Value == null)
                throw new ArgumentNullException(nameof(var0), "Property is not nullable for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.");

            if (var1.IsSet && var1.Value == null)
                throw new ArgumentNullException(nameof(var1), "Property is not nullable for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.");

            if (var2.IsSet && var2.Value == null)
                throw new ArgumentNullException(nameof(var2), "Property is not nullable for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.");

            return new InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue(var0.Value!, var1.Value!.Value!, var2.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.Var0 == null)
                throw new ArgumentNullException(nameof(installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.Var0), "Property is required for class InstallationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.");

            writer.WriteString("0", installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.Var0);

            writer.WriteNumber("1", installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.Var1);

            writer.WriteNumber("2", installationsIdSiteWidgetsGeneratorState200ResponseRecordsDataValue.Var2);
        }
    }
}
