using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class Reprompt
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public OutputSpeech OutputSpeech { get; set; }
    }
}