using ES.FX.Alexa.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill
{
    [HasType("IntentRequest")]
    public class IntentRequest : Request, ICoreRequest
    {
        [JsonProperty("dialogState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DialogState DialogState { get; set; }

        [JsonProperty("intent")]
        public Intent Intent { get; set; }
    }
}