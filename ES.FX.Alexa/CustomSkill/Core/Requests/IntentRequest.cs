using ES.FX.Alexa.CustomSkill.Core.Dialog;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Core.Requests
{
    [SkillRequestType("IntentRequest")]
    public class IntentRequest : Request
    {
        [JsonProperty("dialogState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DialogState DialogState { get; set; }

        [JsonProperty("intent")]
        public Intent Intent { get; set; }
    }
}