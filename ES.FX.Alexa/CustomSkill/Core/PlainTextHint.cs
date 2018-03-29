using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class PlainTextHint : Hint
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}