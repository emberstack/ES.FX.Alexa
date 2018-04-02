using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class HintDirective : Directive
    {
        [JsonProperty("type")]
        public override string Type => "Hint";

        [JsonProperty("hint")]
        public Hint Hint { get; set; }
    }
}