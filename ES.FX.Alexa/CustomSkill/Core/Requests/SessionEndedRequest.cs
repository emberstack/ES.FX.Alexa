using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Core.Requests
{
    [SkillRequestType("SessionEndedRequest")]
    public class SessionEndedRequest : Request
    {
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SessionEndedReason Reason { get; set; }

        [JsonProperty("error")]
        public SystemError Error { get; set; }
    }
}