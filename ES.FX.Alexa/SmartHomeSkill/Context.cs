using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class Context
    {
        [JsonProperty("properties")]
        public List<Property> Properties { get; set; } = new List<Property>();
    }
}