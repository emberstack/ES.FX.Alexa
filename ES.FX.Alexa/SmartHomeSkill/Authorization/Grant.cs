using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public abstract class Grant
    {
        [JsonProperty("type")]
        public abstract string Type { get; set; }
    }
}