using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class PlainTextHint : Hint
    {
        public override string Type => "PlainText";

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}