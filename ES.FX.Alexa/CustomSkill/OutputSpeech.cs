using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public abstract class OutputSpeech
    {
        [JsonProperty("type")]
        [JsonRequired]
        public abstract string Type { get; }
    }
}