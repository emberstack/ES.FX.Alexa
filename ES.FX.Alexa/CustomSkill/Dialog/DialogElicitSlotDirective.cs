using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Dialog
{
    [HasType("Dialog.ElicitSlot")]
    public class DialogElicitSlotDirective : Directive
    {
        public override string Type => "Dialog.ElicitSlot";

        [JsonProperty("slotToElicit")]
        [JsonRequired]
        public string SlotName { get; set; }

        [JsonProperty("updatedIntent", NullValueHandling = NullValueHandling.Ignore)]
        public Intent UpdatedIntent { get; set; }
    }
}