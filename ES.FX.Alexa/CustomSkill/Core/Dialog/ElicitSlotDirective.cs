using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Dialog
{
    public class ElicitSlotDirective : Directive
    {
        [JsonProperty("type")]
        public override string Type => "Dialog.ElicitSlot";

        [JsonProperty("slotToElicit")]
        [JsonRequired]
        public string SlotName { get; set; }

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}