using System;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class Header
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; } = "Alexa";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payloadVersion")]
        public string PayloadVersion { get; set; } = "3";

        [JsonProperty("messageId")]
        public string MessageId { get; set; } = Guid.NewGuid().ToString();

        [JsonProperty("correlationToken")]
        public string CorrelationToken { get; set; }
    }
}