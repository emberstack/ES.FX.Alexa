using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Dialog
{
    public class DialogDelegateDirective : Directive
    {
        public override string Type => "Dialog.Delegate";

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}