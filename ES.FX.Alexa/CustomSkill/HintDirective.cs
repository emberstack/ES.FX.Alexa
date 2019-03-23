using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    [HasType("Hint")]
    public class HintDirective : Directive
    {
        public override string Type => "Hint";

        [JsonProperty("hint")]
        public Hint Hint { get; set; }
    }
}