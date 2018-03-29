using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.UI
{
    public abstract class OutputSpeech
    {
        [JsonProperty("type")]
        [JsonRequired]
        public abstract string Type { get; }
    }
}