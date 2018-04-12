using ES.FX.Alexa.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [HasType("SessionEndedRequest")]
    public class SessionEndedRequest : Request, ICoreRequest
    {
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SessionEndedReason Reason { get; set; }

        [JsonProperty("error")]
        public SystemError Error { get; set; }
    }
}