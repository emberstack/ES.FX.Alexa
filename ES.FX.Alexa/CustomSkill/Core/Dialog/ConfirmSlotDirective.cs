using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Dialog
{
    public class ConfirmSlotDirective : Directive
    {
        public override string Type => "Dialog.ConfirmSlot";

        [JsonProperty("slotToConfirm")]
        [JsonRequired]
        public string SlotName { get; set; }

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}