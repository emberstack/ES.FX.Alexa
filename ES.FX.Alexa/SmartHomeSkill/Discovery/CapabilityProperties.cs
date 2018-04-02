using System.Collections.Generic;
using ES.FX.Alexa.SmartHomeSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class CapabilityProperties
    {
        [JsonProperty("supported")]
        public List<NameValue> Supported { get; set; } = new List<NameValue>();

        [JsonProperty("proactivelyReported")]
        public bool ProactivelyReported { get; set; }

        [JsonProperty("retrievable")]
        public bool Retrievable { get; set; }
    }
}