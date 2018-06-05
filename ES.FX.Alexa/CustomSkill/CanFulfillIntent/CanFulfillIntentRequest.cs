using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.CanFulfillIntent
{
    [HasType("CanFulfillIntentRequest")]
    public class CanFulfillIntentRequest : Request, ICoreRequest
    {
        [JsonProperty("intent")]
        public Intent Intent { get; set; }
    }
}