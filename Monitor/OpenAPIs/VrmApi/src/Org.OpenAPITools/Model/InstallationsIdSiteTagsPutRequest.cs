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
    /// InstallationsIdSiteTagsPutRequest
    /// </summary>
    public partial class InstallationsIdSiteTagsPutRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationsIdSiteTagsPutRequest" /> class.
        /// </summary>
        /// <param name="tag">tag</param>
        /// <param name="source">source</param>
        [JsonConstructor]
        public InstallationsIdSiteTagsPutRequest(Option<string?> tag = default, Option<string?> source = default)
        {
            TagOption = tag;
            SourceOption = source;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Tag
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TagOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        /* <example>Foo</example> */
        [JsonPropertyName("tag")]
        public string? Tag { get { return this.TagOption; } set { this.TagOption = new(value); } }

        /// <summary>
        /// Used to track the state of Source
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SourceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        /* <example>user</example> */
        [JsonPropertyName("source")]
        public string? Source { get { return this.SourceOption; } set { this.SourceOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationsIdSiteTagsPutRequest {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
    /// A Json converter for type <see cref="InstallationsIdSiteTagsPutRequest" />
    /// </summary>
    public class InstallationsIdSiteTagsPutRequestJsonConverter : JsonConverter<InstallationsIdSiteTagsPutRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallationsIdSiteTagsPutRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationsIdSiteTagsPutRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> tag = default;
            Option<string?> source = default;

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
                        case "tag":
                            tag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "source":
                            source = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class InstallationsIdSiteTagsPutRequest.");

            if (source.IsSet && source.Value == null)
                throw new ArgumentNullException(nameof(source), "Property is not nullable for class InstallationsIdSiteTagsPutRequest.");

            return new InstallationsIdSiteTagsPutRequest(tag, source);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationsIdSiteTagsPutRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteTagsPutRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationsIdSiteTagsPutRequest installationsIdSiteTagsPutRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installationsIdSiteTagsPutRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationsIdSiteTagsPutRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteTagsPutRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationsIdSiteTagsPutRequest installationsIdSiteTagsPutRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installationsIdSiteTagsPutRequest.TagOption.IsSet && installationsIdSiteTagsPutRequest.Tag == null)
                throw new ArgumentNullException(nameof(installationsIdSiteTagsPutRequest.Tag), "Property is required for class InstallationsIdSiteTagsPutRequest.");

            if (installationsIdSiteTagsPutRequest.SourceOption.IsSet && installationsIdSiteTagsPutRequest.Source == null)
                throw new ArgumentNullException(nameof(installationsIdSiteTagsPutRequest.Source), "Property is required for class InstallationsIdSiteTagsPutRequest.");

            if (installationsIdSiteTagsPutRequest.TagOption.IsSet)
                writer.WriteString("tag", installationsIdSiteTagsPutRequest.Tag);

            if (installationsIdSiteTagsPutRequest.SourceOption.IsSet)
                writer.WriteString("source", installationsIdSiteTagsPutRequest.Source);
        }
    }
}
