using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Dialog
{
    [HasType("Dialog.Delegate")]
    public class DialogDelegateDirective : Directive
    {
        public override string Type => "Dialog.Delegate";

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}