using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class TypedCode
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}