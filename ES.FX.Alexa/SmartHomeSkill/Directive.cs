using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public abstract class Directive
    {
        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("endpoint")]
        public Endpoint Endpoint { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }

        public override string ToString()
        {
            return Header != null ? $"{Header.Namespace}.{Header.Name}" : base.ToString();
        }
    }
}