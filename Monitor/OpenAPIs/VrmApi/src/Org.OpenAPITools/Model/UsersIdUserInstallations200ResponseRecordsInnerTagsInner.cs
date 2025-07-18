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
    /// A single tag.
    /// </summary>
    public partial class UsersIdUserInstallations200ResponseRecordsInnerTagsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersIdUserInstallations200ResponseRecordsInnerTagsInner" /> class.
        /// </summary>
        /// <param name="idTag">Tag id.</param>
        /// <param name="name">Tag name.</param>
        /// <param name="automatic">False this tag was created by a user.</param>
        [JsonConstructor]
        public UsersIdUserInstallations200ResponseRecordsInnerTagsInner(int idTag, string name, bool automatic)
        {
            IdTag = idTag;
            Name = name;
            Automatic = automatic;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Tag id.
        /// </summary>
        /// <value>Tag id.</value>
        [JsonPropertyName("idTag")]
        public int IdTag { get; set; }

        /// <summary>
        /// Tag name.
        /// </summary>
        /// <value>Tag name.</value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// False this tag was created by a user.
        /// </summary>
        /// <value>False this tag was created by a user.</value>
        [JsonPropertyName("automatic")]
        public bool Automatic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersIdUserInstallations200ResponseRecordsInnerTagsInner {\n");
            sb.Append("  IdTag: ").Append(IdTag).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Automatic: ").Append(Automatic).Append("\n");
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
    /// A Json converter for type <see cref="UsersIdUserInstallations200ResponseRecordsInnerTagsInner" />
    /// </summary>
    public class UsersIdUserInstallations200ResponseRecordsInnerTagsInnerJsonConverter : JsonConverter<UsersIdUserInstallations200ResponseRecordsInnerTagsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsersIdUserInstallations200ResponseRecordsInnerTagsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsersIdUserInstallations200ResponseRecordsInnerTagsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> idTag = default;
            Option<string?> name = default;
            Option<bool?> automatic = default;

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
                        case "idTag":
                            idTag = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "automatic":
                            automatic = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!idTag.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.", nameof(idTag));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.", nameof(name));

            if (!automatic.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.", nameof(automatic));

            if (idTag.IsSet && idTag.Value == null)
                throw new ArgumentNullException(nameof(idTag), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.");

            if (automatic.IsSet && automatic.Value == null)
                throw new ArgumentNullException(nameof(automatic), "Property is not nullable for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.");

            return new UsersIdUserInstallations200ResponseRecordsInnerTagsInner(idTag.Value!.Value!, name.Value!, automatic.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="UsersIdUserInstallations200ResponseRecordsInnerTagsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserInstallations200ResponseRecordsInnerTagsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsersIdUserInstallations200ResponseRecordsInnerTagsInner usersIdUserInstallations200ResponseRecordsInnerTagsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usersIdUserInstallations200ResponseRecordsInnerTagsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsersIdUserInstallations200ResponseRecordsInnerTagsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserInstallations200ResponseRecordsInnerTagsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsersIdUserInstallations200ResponseRecordsInnerTagsInner usersIdUserInstallations200ResponseRecordsInnerTagsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usersIdUserInstallations200ResponseRecordsInnerTagsInner.Name == null)
                throw new ArgumentNullException(nameof(usersIdUserInstallations200ResponseRecordsInnerTagsInner.Name), "Property is required for class UsersIdUserInstallations200ResponseRecordsInnerTagsInner.");

            writer.WriteNumber("idTag", usersIdUserInstallations200ResponseRecordsInnerTagsInner.IdTag);

            writer.WriteString("name", usersIdUserInstallations200ResponseRecordsInnerTagsInner.Name);

            writer.WriteBoolean("automatic", usersIdUserInstallations200ResponseRecordsInnerTagsInner.Automatic);
        }
    }
}
