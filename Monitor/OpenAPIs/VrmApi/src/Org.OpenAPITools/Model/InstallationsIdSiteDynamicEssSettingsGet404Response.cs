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
    /// InstallationsIdSiteDynamicEssSettingsGet404Response
    /// </summary>
    public partial class InstallationsIdSiteDynamicEssSettingsGet404Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationsIdSiteDynamicEssSettingsGet404Response" /> class.
        /// </summary>
        /// <param name="success">True if the request was successful.</param>
        /// <param name="errors">Installation with the given ID was not found.</param>
        /// <param name="errorCode">The error code, if applicable.</param>
        [JsonConstructor]
        public InstallationsIdSiteDynamicEssSettingsGet404Response(bool success, string errors, string? errorCode = default)
        {
            Success = success;
            Errors = errors;
            ErrorCode = errorCode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// True if the request was successful.
        /// </summary>
        /// <value>True if the request was successful.</value>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Installation with the given ID was not found.
        /// </summary>
        /// <value>Installation with the given ID was not found.</value>
        [JsonPropertyName("errors")]
        public string Errors { get; set; }

        /// <summary>
        /// The error code, if applicable.
        /// </summary>
        /// <value>The error code, if applicable.</value>
        [JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationsIdSiteDynamicEssSettingsGet404Response {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
    /// A Json converter for type <see cref="InstallationsIdSiteDynamicEssSettingsGet404Response" />
    /// </summary>
    public class InstallationsIdSiteDynamicEssSettingsGet404ResponseJsonConverter : JsonConverter<InstallationsIdSiteDynamicEssSettingsGet404Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallationsIdSiteDynamicEssSettingsGet404Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationsIdSiteDynamicEssSettingsGet404Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> success = default;
            Option<string?> errors = default;
            Option<string?> errorCode = default;

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
                        case "success":
                            success = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "errors":
                            errors = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "error_code":
                            errorCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!success.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDynamicEssSettingsGet404Response.", nameof(success));

            if (!errors.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDynamicEssSettingsGet404Response.", nameof(errors));

            if (!errorCode.IsSet)
                throw new ArgumentException("Property is required for class InstallationsIdSiteDynamicEssSettingsGet404Response.", nameof(errorCode));

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class InstallationsIdSiteDynamicEssSettingsGet404Response.");

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class InstallationsIdSiteDynamicEssSettingsGet404Response.");

            return new InstallationsIdSiteDynamicEssSettingsGet404Response(success.Value!.Value!, errors.Value!, errorCode.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationsIdSiteDynamicEssSettingsGet404Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteDynamicEssSettingsGet404Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationsIdSiteDynamicEssSettingsGet404Response installationsIdSiteDynamicEssSettingsGet404Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installationsIdSiteDynamicEssSettingsGet404Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationsIdSiteDynamicEssSettingsGet404Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteDynamicEssSettingsGet404Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationsIdSiteDynamicEssSettingsGet404Response installationsIdSiteDynamicEssSettingsGet404Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installationsIdSiteDynamicEssSettingsGet404Response.Errors == null)
                throw new ArgumentNullException(nameof(installationsIdSiteDynamicEssSettingsGet404Response.Errors), "Property is required for class InstallationsIdSiteDynamicEssSettingsGet404Response.");

            writer.WriteBoolean("success", installationsIdSiteDynamicEssSettingsGet404Response.Success);

            writer.WriteString("errors", installationsIdSiteDynamicEssSettingsGet404Response.Errors);

            if (installationsIdSiteDynamicEssSettingsGet404Response.ErrorCode != null)
                writer.WriteString("error_code", installationsIdSiteDynamicEssSettingsGet404Response.ErrorCode);
            else
                writer.WriteNull("error_code");
        }
    }
}
