using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class Permission
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}