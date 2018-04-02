using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class Endpoint
    {
        [JsonProperty("scope")]
        public TypedToken Scope { get; set; }

        [JsonProperty("endpointId")]
        public string EndpointId { get; set; }

        [JsonProperty("cookie")]
        public Dictionary<string,dynamic> Cookie { get; set; }
    }
}
