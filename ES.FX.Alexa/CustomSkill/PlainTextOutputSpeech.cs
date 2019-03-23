using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    [HasType("PlainText")]
    public class PlainTextOutputSpeech : OutputSpeech
    {
        [JsonProperty("text")]
        [JsonRequired]
        public string Text { get; set; }

        public override string Type => "PlainText";
    }
}