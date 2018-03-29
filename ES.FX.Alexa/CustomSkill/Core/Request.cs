﻿using System;
using System.Collections.Generic;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public abstract class Request
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }

        /// <summary>
        ///     Provides access to the request envelope details, such as <see cref="RequestEnvelope.Version" />,
        ///     <see cref="RequestEnvelope.Context" /> or <see cref="RequestEnvelope.Session" />
        /// </summary>
        [JsonIgnore]
        public RequestEnvelope Envelope { get; internal set; }
    }
}