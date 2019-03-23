using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    [HasType("SSML")]
    public class SsmlOutputSpeech : OutputSpeech
    {
        public override string Type => "SSML";

        [JsonRequired]
        [JsonProperty("ssml")]
        public string Ssml { get; set; }
    }
}