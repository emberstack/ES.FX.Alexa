using ES.FX.Alexa.SmartHomeSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class SmartHomeResponse
    {
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public Context Context { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }
    }
}