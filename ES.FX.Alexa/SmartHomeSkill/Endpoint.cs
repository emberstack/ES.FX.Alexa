using System.Collections.Generic;
using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class Endpoint
    {
        [JsonConverter(typeof(WithTypeConverter<Scope, ScopeDefault>))]
        [JsonProperty("scope")]
        public Scope Scope { get; set; }

        [JsonProperty("endpointId")]
        public string EndpointId { get; set; }

        [JsonProperty("cookie")]
        public Dictionary<string, dynamic> Cookie { get; set; }
    }
}