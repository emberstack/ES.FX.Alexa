using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public abstract class Hint
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}