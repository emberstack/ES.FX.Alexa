using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class Permission
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}