using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class RichTextHint : Hint
    {
        public override string Type => "RichText";

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}