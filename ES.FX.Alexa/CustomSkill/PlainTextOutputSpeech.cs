using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class PlainTextOutputSpeech : OutputSpeech
    {
        [JsonProperty("text")]
        [JsonRequired]
        public string Text { get; set; }

        public override string Type => "PlainText";
    }
}