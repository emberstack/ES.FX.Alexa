using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Dialog
{
    public class DelegateDirective : Directive
    {
        public override string Type => "Dialog.Delegate";

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}