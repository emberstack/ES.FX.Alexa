using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public abstract class Directive
    {
        [JsonProperty("type")]
        [JsonRequired]
        public abstract string Type { get; }
    }
}