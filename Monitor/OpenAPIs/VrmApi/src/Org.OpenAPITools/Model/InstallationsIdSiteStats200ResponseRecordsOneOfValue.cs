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
    /// InstallationsIdSiteStats200ResponseRecordsOneOfValue
    /// </summary>
    public partial class InstallationsIdSiteStats200ResponseRecordsOneOfValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationsIdSiteStats200ResponseRecordsOneOfValue" /> class.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="bool"></param>
        internal InstallationsIdSiteStats200ResponseRecordsOneOfValue(Option<List<List<decimal>>?> list, Option<bool?> @bool)
        {
            ListOption = list;
            BoolOption = @bool;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of List
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<List<decimal>>?> ListOption { get; private set; }

        /// <summary>
        /// Data points for statistic with this key.
        /// </summary>
        /// <value>Data points for statistic with this key.</value>
        public List<List<decimal>>? List { get { return this.ListOption; } set { this.ListOption = new(value); } }

        /// <summary>
        /// Used to track the state of Bool
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> BoolOption { get; private set; }

        /// <summary>
        /// Statistic without data within the given timeframe.
        /// </summary>
        /// <value>Statistic without data within the given timeframe.</value>
        public bool? Bool { get { return this.BoolOption; } set { this.BoolOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationsIdSiteStats200ResponseRecordsOneOfValue {\n");
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
    /// A Json converter for type <see cref="InstallationsIdSiteStats200ResponseRecordsOneOfValue" />
    /// </summary>
    public class InstallationsIdSiteStats200ResponseRecordsOneOfValueJsonConverter : JsonConverter<InstallationsIdSiteStats200ResponseRecordsOneOfValue>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallationsIdSiteStats200ResponseRecordsOneOfValue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationsIdSiteStats200ResponseRecordsOneOfValue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<List<decimal>>? list = default;
            bool? varBool = default;

            Utf8JsonReader utf8JsonReaderAnyOf = utf8JsonReader;
            while (utf8JsonReaderAnyOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (utf8JsonReaderAnyOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderAnyOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderList = utf8JsonReader;
                    ClientUtils.TryDeserialize<List<List<decimal>>?>(ref utf8JsonReaderList, jsonSerializerOptions, out list);

                    Utf8JsonReader utf8JsonReaderBool = utf8JsonReader;
                    ClientUtils.TryDeserialize<bool?>(ref utf8JsonReaderBool, jsonSerializerOptions, out varBool);
                }
            }

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
                        default:
                            break;
                    }
                }
            }

            Option< List < List<decimal> >?> listParsedValue = list == null
                ? default
                : new Option<List<List<decimal>>?>(list);
            Option<bool?> varBoolParsedValue = varBool == null
                ? default
                : new Option<bool?>(varBool);

            return new InstallationsIdSiteStats200ResponseRecordsOneOfValue(listParsedValue, varBoolParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationsIdSiteStats200ResponseRecordsOneOfValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteStats200ResponseRecordsOneOfValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationsIdSiteStats200ResponseRecordsOneOfValue installationsIdSiteStats200ResponseRecordsOneOfValue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (installationsIdSiteStats200ResponseRecordsOneOfValue.ListOption.IsSet && installationsIdSiteStats200ResponseRecordsOneOfValue.ListOption.Value != null)

            if (installationsIdSiteStats200ResponseRecordsOneOfValue.BoolOption.IsSet && installationsIdSiteStats200ResponseRecordsOneOfValue.BoolOption.Value != null)
                writer.WriteBoolean("value", installationsIdSiteStats200ResponseRecordsOneOfValue.BoolOption.Value.Value);

            WriteProperties(writer, installationsIdSiteStats200ResponseRecordsOneOfValue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationsIdSiteStats200ResponseRecordsOneOfValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationsIdSiteStats200ResponseRecordsOneOfValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationsIdSiteStats200ResponseRecordsOneOfValue installationsIdSiteStats200ResponseRecordsOneOfValue, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
