using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [HasType("AlexaSkillEvent.SkillPermissionAccepted")]
    public class SkillPermissionAcceptedRequest : Request, ICoreRequest
    {
        [JsonProperty("body")]
        public PermissionBody Body { get; set; }
    }
}