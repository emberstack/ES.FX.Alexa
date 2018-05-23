using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public abstract class Grantee
    {
        [JsonProperty("type")]
        public abstract string Type { get; set; }
    }
}