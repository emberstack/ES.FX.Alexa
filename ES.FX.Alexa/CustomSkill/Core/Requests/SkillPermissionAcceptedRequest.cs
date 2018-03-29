using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Requests
{
    [SkillRequestType("AlexaSkillEvent.SkillPermissionAccepted")]
    public class SkillPermissionAcceptedRequest : Request
    {
        [JsonProperty("body")]
        public PermissionBody Body { get; set; }
    }
}