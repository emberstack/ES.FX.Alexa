using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class SmartHomeResponse
    {
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public Context Context { get; set; } = new Context();

        [JsonProperty("event")]
        public Event Event { get; set; } = new Event();
    }
}