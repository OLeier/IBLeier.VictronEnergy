﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Monitor.VrmApi.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class SolarChargerSummaryOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the SolarChargerSummaryOKResponse
        /// class.
        /// </summary>
        public SolarChargerSummaryOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the SolarChargerSummaryOKResponse
        /// class.
        /// </summary>
        public SolarChargerSummaryOKResponse(bool? success = default(bool?), SolarChargerSummaryOKResponseRecords records = default(SolarChargerSummaryOKResponseRecords))
        {
            Success = success;
            Records = records;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public SolarChargerSummaryOKResponseRecords Records { get; set; }

    }
}
