using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.UI
{
    public class SsmlOutputSpeech : OutputSpeech
    {
        public override string Type => "SSML";

        [JsonRequired]
        [JsonProperty("ssml")]
        public string Ssml { get; set; }
    }
}