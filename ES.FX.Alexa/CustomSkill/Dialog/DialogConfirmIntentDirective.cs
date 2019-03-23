using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Dialog
{
    [HasType("Dialog.ConfirmIntent")]
    public class DialogConfirmIntentDirective : Directive
    {
        public override string Type => "Dialog.ConfirmIntent";

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}