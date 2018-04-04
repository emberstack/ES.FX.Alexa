using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class Event
    {
        [JsonProperty("header")]
        public Header Header { get; set; } = new Header
        {
            Name = "Response"
        };

        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint Endpoint { get; set; }
    }
}