using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public abstract class Scope
    {
        [JsonProperty("type")]
        public abstract string Type { get; set; }
    }
}