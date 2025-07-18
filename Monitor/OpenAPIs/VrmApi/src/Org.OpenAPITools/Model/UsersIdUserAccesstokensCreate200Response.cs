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
    /// UsersIdUserAccesstokensCreate200Response
    /// </summary>
    public partial class UsersIdUserAccesstokensCreate200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersIdUserAccesstokensCreate200Response" /> class.
        /// </summary>
        /// <param name="success">Whether the request was successful.</param>
        /// <param name="token">Generated access token.</param>
        /// <param name="idAccessToken">Access token id.</param>
        [JsonConstructor]
        public UsersIdUserAccesstokensCreate200Response(bool success, int token, string idAccessToken)
        {
            Success = success;
            Token = token;
            IdAccessToken = idAccessToken;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Whether the request was successful.
        /// </summary>
        /// <value>Whether the request was successful.</value>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Generated access token.
        /// </summary>
        /// <value>Generated access token.</value>
        [JsonPropertyName("token")]
        public int Token { get; set; }

        /// <summary>
        /// Access token id.
        /// </summary>
        /// <value>Access token id.</value>
        [JsonPropertyName("idAccessToken")]
        public string IdAccessToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersIdUserAccesstokensCreate200Response {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  IdAccessToken: ").Append(IdAccessToken).Append("\n");
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
    /// A Json converter for type <see cref="UsersIdUserAccesstokensCreate200Response" />
    /// </summary>
    public class UsersIdUserAccesstokensCreate200ResponseJsonConverter : JsonConverter<UsersIdUserAccesstokensCreate200Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="UsersIdUserAccesstokensCreate200Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UsersIdUserAccesstokensCreate200Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> success = default;
            Option<int?> token = default;
            Option<string?> idAccessToken = default;

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
                        case "token":
                            token = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "idAccessToken":
                            idAccessToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!success.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserAccesstokensCreate200Response.", nameof(success));

            if (!token.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserAccesstokensCreate200Response.", nameof(token));

            if (!idAccessToken.IsSet)
                throw new ArgumentException("Property is required for class UsersIdUserAccesstokensCreate200Response.", nameof(idAccessToken));

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class UsersIdUserAccesstokensCreate200Response.");

            if (token.IsSet && token.Value == null)
                throw new ArgumentNullException(nameof(token), "Property is not nullable for class UsersIdUserAccesstokensCreate200Response.");

            if (idAccessToken.IsSet && idAccessToken.Value == null)
                throw new ArgumentNullException(nameof(idAccessToken), "Property is not nullable for class UsersIdUserAccesstokensCreate200Response.");

            return new UsersIdUserAccesstokensCreate200Response(success.Value!.Value!, token.Value!.Value!, idAccessToken.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="UsersIdUserAccesstokensCreate200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserAccesstokensCreate200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UsersIdUserAccesstokensCreate200Response usersIdUserAccesstokensCreate200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, usersIdUserAccesstokensCreate200Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UsersIdUserAccesstokensCreate200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="usersIdUserAccesstokensCreate200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UsersIdUserAccesstokensCreate200Response usersIdUserAccesstokensCreate200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (usersIdUserAccesstokensCreate200Response.IdAccessToken == null)
                throw new ArgumentNullException(nameof(usersIdUserAccesstokensCreate200Response.IdAccessToken), "Property is required for class UsersIdUserAccesstokensCreate200Response.");

            writer.WriteBoolean("success", usersIdUserAccesstokensCreate200Response.Success);

            writer.WriteNumber("token", usersIdUserAccesstokensCreate200Response.Token);

            writer.WriteString("idAccessToken", usersIdUserAccesstokensCreate200Response.IdAccessToken);
        }
    }
}
