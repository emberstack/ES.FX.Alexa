using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Requests
{
    [SkillRequestType("AlexaSkillEvent.SkillPermissionChanged")]
    public class SkillPermissionChangedRequest : Request
    {
        [JsonProperty("body")]
        public PermissionBody Body { get; set; }
    }
}