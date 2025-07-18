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
    /// Data for each installation.
    /// </summary>
    public partial class InstallationOverviewDownload200ResponseDataValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationOverviewDownload200ResponseDataValue" /> class.
        /// </summary>
        /// <param name="installationName">Name of the installation.</param>
        /// <param name="batteryVoltage">Battery voltage (e.g., \&quot;50.00 V\&quot;).</param>
        /// <param name="battery">Battery percentage (e.g., \&quot;100.0 %\&quot;).</param>
        /// <param name="batteryMode">Current battery mode (e.g., \&quot;Charging\&quot;).</param>
        /// <param name="load">Current load in watts (e.g., \&quot;118 W\&quot;).</param>
        /// <param name="solarYield">Solar yield in watts (e.g., \&quot;117 W\&quot;).</param>
        /// <param name="grid">Grid power in watts.</param>
        /// <param name="generator">Generator power in watts.</param>
        /// <param name="tanks">Information about tank levels (e.g., \&quot;Fuel-20 %\&quot;).</param>
        /// <param name="temperature">Temperature readings (e.g., \&quot;Battery-27.0 °C\&quot;).</param>
        /// <param name="lastUpdate">Timestamp of the last update.</param>
        [JsonConstructor]
        public InstallationOverviewDownload200ResponseDataValue(Option<string?> installationName = default, Option<string?> batteryVoltage = default, Option<string?> battery = default, Option<string?> batteryMode = default, Option<string?> load = default, Option<string?> solarYield = default, Option<string?> grid = default, Option<string?> generator = default, Option<string?> tanks = default, Option<string?> temperature = default, Option<DateTime?> lastUpdate = default)
        {
            InstallationNameOption = installationName;
            BatteryVoltageOption = batteryVoltage;
            BatteryOption = battery;
            BatteryModeOption = batteryMode;
            LoadOption = load;
            SolarYieldOption = solarYield;
            GridOption = grid;
            GeneratorOption = generator;
            TanksOption = tanks;
            TemperatureOption = temperature;
            LastUpdateOption = lastUpdate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of InstallationName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> InstallationNameOption { get; private set; }

        /// <summary>
        /// Name of the installation.
        /// </summary>
        /// <value>Name of the installation.</value>
        [JsonPropertyName("Installation name")]
        public string? InstallationName { get { return this.InstallationNameOption; } set { this.InstallationNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of BatteryVoltage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BatteryVoltageOption { get; private set; }

        /// <summary>
        /// Battery voltage (e.g., \&quot;50.00 V\&quot;).
        /// </summary>
        /// <value>Battery voltage (e.g., \&quot;50.00 V\&quot;).</value>
        [JsonPropertyName("Battery Voltage")]
        public string? BatteryVoltage { get { return this.BatteryVoltageOption; } set { this.BatteryVoltageOption = new(value); } }

        /// <summary>
        /// Used to track the state of Battery
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BatteryOption { get; private set; }

        /// <summary>
        /// Battery percentage (e.g., \&quot;100.0 %\&quot;).
        /// </summary>
        /// <value>Battery percentage (e.g., \&quot;100.0 %\&quot;).</value>
        [JsonPropertyName("Battery %")]
        public string? Battery { get { return this.BatteryOption; } set { this.BatteryOption = new(value); } }

        /// <summary>
        /// Used to track the state of BatteryMode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BatteryModeOption { get; private set; }

        /// <summary>
        /// Current battery mode (e.g., \&quot;Charging\&quot;).
        /// </summary>
        /// <value>Current battery mode (e.g., \&quot;Charging\&quot;).</value>
        [JsonPropertyName("Battery Mode")]
        public string? BatteryMode { get { return this.BatteryModeOption; } set { this.BatteryModeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Load
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LoadOption { get; private set; }

        /// <summary>
        /// Current load in watts (e.g., \&quot;118 W\&quot;).
        /// </summary>
        /// <value>Current load in watts (e.g., \&quot;118 W\&quot;).</value>
        [JsonPropertyName("Load")]
        public string? Load { get { return this.LoadOption; } set { this.LoadOption = new(value); } }

        /// <summary>
        /// Used to track the state of SolarYield
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SolarYieldOption { get; private set; }

        /// <summary>
        /// Solar yield in watts (e.g., \&quot;117 W\&quot;).
        /// </summary>
        /// <value>Solar yield in watts (e.g., \&quot;117 W\&quot;).</value>
        [JsonPropertyName("Solar Yield")]
        public string? SolarYield { get { return this.SolarYieldOption; } set { this.SolarYieldOption = new(value); } }

        /// <summary>
        /// Used to track the state of Grid
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GridOption { get; private set; }

        /// <summary>
        /// Grid power in watts.
        /// </summary>
        /// <value>Grid power in watts.</value>
        [JsonPropertyName("Grid")]
        public string? Grid { get { return this.GridOption; } set { this.GridOption = new(value); } }

        /// <summary>
        /// Used to track the state of Generator
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GeneratorOption { get; private set; }

        /// <summary>
        /// Generator power in watts.
        /// </summary>
        /// <value>Generator power in watts.</value>
        [JsonPropertyName("Generator")]
        public string? Generator { get { return this.GeneratorOption; } set { this.GeneratorOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tanks
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TanksOption { get; private set; }

        /// <summary>
        /// Information about tank levels (e.g., \&quot;Fuel-20 %\&quot;).
        /// </summary>
        /// <value>Information about tank levels (e.g., \&quot;Fuel-20 %\&quot;).</value>
        [JsonPropertyName("Tanks")]
        public string? Tanks { get { return this.TanksOption; } set { this.TanksOption = new(value); } }

        /// <summary>
        /// Used to track the state of Temperature
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TemperatureOption { get; private set; }

        /// <summary>
        /// Temperature readings (e.g., \&quot;Battery-27.0 °C\&quot;).
        /// </summary>
        /// <value>Temperature readings (e.g., \&quot;Battery-27.0 °C\&quot;).</value>
        [JsonPropertyName("Temperature")]
        public string? Temperature { get { return this.TemperatureOption; } set { this.TemperatureOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// Timestamp of the last update.
        /// </summary>
        /// <value>Timestamp of the last update.</value>
        [JsonPropertyName("Last Update")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallationOverviewDownload200ResponseDataValue {\n");
            sb.Append("  InstallationName: ").Append(InstallationName).Append("\n");
            sb.Append("  BatteryVoltage: ").Append(BatteryVoltage).Append("\n");
            sb.Append("  Battery: ").Append(Battery).Append("\n");
            sb.Append("  BatteryMode: ").Append(BatteryMode).Append("\n");
            sb.Append("  Load: ").Append(Load).Append("\n");
            sb.Append("  SolarYield: ").Append(SolarYield).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
            sb.Append("  Generator: ").Append(Generator).Append("\n");
            sb.Append("  Tanks: ").Append(Tanks).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
    /// A Json converter for type <see cref="InstallationOverviewDownload200ResponseDataValue" />
    /// </summary>
    public class InstallationOverviewDownload200ResponseDataValueJsonConverter : JsonConverter<InstallationOverviewDownload200ResponseDataValue>
    {
        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="InstallationOverviewDownload200ResponseDataValue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallationOverviewDownload200ResponseDataValue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> installationName = default;
            Option<string?> batteryVoltage = default;
            Option<string?> battery = default;
            Option<string?> batteryMode = default;
            Option<string?> load = default;
            Option<string?> solarYield = default;
            Option<string?> grid = default;
            Option<string?> generator = default;
            Option<string?> tanks = default;
            Option<string?> temperature = default;
            Option<DateTime?> lastUpdate = default;

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
                        case "Installation name":
                            installationName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Battery Voltage":
                            batteryVoltage = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Battery %":
                            battery = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Battery Mode":
                            batteryMode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Load":
                            load = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Solar Yield":
                            solarYield = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Grid":
                            grid = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Generator":
                            generator = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Tanks":
                            tanks = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Temperature":
                            temperature = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Last Update":
                            lastUpdate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (installationName.IsSet && installationName.Value == null)
                throw new ArgumentNullException(nameof(installationName), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (batteryVoltage.IsSet && batteryVoltage.Value == null)
                throw new ArgumentNullException(nameof(batteryVoltage), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (battery.IsSet && battery.Value == null)
                throw new ArgumentNullException(nameof(battery), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (batteryMode.IsSet && batteryMode.Value == null)
                throw new ArgumentNullException(nameof(batteryMode), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (load.IsSet && load.Value == null)
                throw new ArgumentNullException(nameof(load), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (solarYield.IsSet && solarYield.Value == null)
                throw new ArgumentNullException(nameof(solarYield), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (grid.IsSet && grid.Value == null)
                throw new ArgumentNullException(nameof(grid), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (generator.IsSet && generator.Value == null)
                throw new ArgumentNullException(nameof(generator), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (tanks.IsSet && tanks.Value == null)
                throw new ArgumentNullException(nameof(tanks), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (temperature.IsSet && temperature.Value == null)
                throw new ArgumentNullException(nameof(temperature), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class InstallationOverviewDownload200ResponseDataValue.");

            return new InstallationOverviewDownload200ResponseDataValue(installationName, batteryVoltage, battery, batteryMode, load, solarYield, grid, generator, tanks, temperature, lastUpdate);
        }

        /// <summary>
        /// Serializes a <see cref="InstallationOverviewDownload200ResponseDataValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationOverviewDownload200ResponseDataValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallationOverviewDownload200ResponseDataValue installationOverviewDownload200ResponseDataValue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installationOverviewDownload200ResponseDataValue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallationOverviewDownload200ResponseDataValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installationOverviewDownload200ResponseDataValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallationOverviewDownload200ResponseDataValue installationOverviewDownload200ResponseDataValue, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installationOverviewDownload200ResponseDataValue.InstallationNameOption.IsSet && installationOverviewDownload200ResponseDataValue.InstallationName == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.InstallationName), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.BatteryVoltageOption.IsSet && installationOverviewDownload200ResponseDataValue.BatteryVoltage == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.BatteryVoltage), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.BatteryOption.IsSet && installationOverviewDownload200ResponseDataValue.Battery == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.Battery), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.BatteryModeOption.IsSet && installationOverviewDownload200ResponseDataValue.BatteryMode == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.BatteryMode), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.LoadOption.IsSet && installationOverviewDownload200ResponseDataValue.Load == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.Load), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.SolarYieldOption.IsSet && installationOverviewDownload200ResponseDataValue.SolarYield == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.SolarYield), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.GridOption.IsSet && installationOverviewDownload200ResponseDataValue.Grid == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.Grid), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.GeneratorOption.IsSet && installationOverviewDownload200ResponseDataValue.Generator == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.Generator), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.TanksOption.IsSet && installationOverviewDownload200ResponseDataValue.Tanks == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.Tanks), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.TemperatureOption.IsSet && installationOverviewDownload200ResponseDataValue.Temperature == null)
                throw new ArgumentNullException(nameof(installationOverviewDownload200ResponseDataValue.Temperature), "Property is required for class InstallationOverviewDownload200ResponseDataValue.");

            if (installationOverviewDownload200ResponseDataValue.InstallationNameOption.IsSet)
                writer.WriteString("Installation name", installationOverviewDownload200ResponseDataValue.InstallationName);

            if (installationOverviewDownload200ResponseDataValue.BatteryVoltageOption.IsSet)
                writer.WriteString("Battery Voltage", installationOverviewDownload200ResponseDataValue.BatteryVoltage);

            if (installationOverviewDownload200ResponseDataValue.BatteryOption.IsSet)
                writer.WriteString("Battery %", installationOverviewDownload200ResponseDataValue.Battery);

            if (installationOverviewDownload200ResponseDataValue.BatteryModeOption.IsSet)
                writer.WriteString("Battery Mode", installationOverviewDownload200ResponseDataValue.BatteryMode);

            if (installationOverviewDownload200ResponseDataValue.LoadOption.IsSet)
                writer.WriteString("Load", installationOverviewDownload200ResponseDataValue.Load);

            if (installationOverviewDownload200ResponseDataValue.SolarYieldOption.IsSet)
                writer.WriteString("Solar Yield", installationOverviewDownload200ResponseDataValue.SolarYield);

            if (installationOverviewDownload200ResponseDataValue.GridOption.IsSet)
                writer.WriteString("Grid", installationOverviewDownload200ResponseDataValue.Grid);

            if (installationOverviewDownload200ResponseDataValue.GeneratorOption.IsSet)
                writer.WriteString("Generator", installationOverviewDownload200ResponseDataValue.Generator);

            if (installationOverviewDownload200ResponseDataValue.TanksOption.IsSet)
                writer.WriteString("Tanks", installationOverviewDownload200ResponseDataValue.Tanks);

            if (installationOverviewDownload200ResponseDataValue.TemperatureOption.IsSet)
                writer.WriteString("Temperature", installationOverviewDownload200ResponseDataValue.Temperature);

            if (installationOverviewDownload200ResponseDataValue.LastUpdateOption.IsSet)
                writer.WriteString("Last Update", installationOverviewDownload200ResponseDataValue.LastUpdateOption.Value!.Value.ToString(LastUpdateFormat));
        }
    }
}
