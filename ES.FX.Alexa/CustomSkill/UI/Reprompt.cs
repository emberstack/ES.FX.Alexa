using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.UI
{
    public class Reprompt
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public OutputSpeech OutputSpeech { get; set; }
    }
}