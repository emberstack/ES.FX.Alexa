using ES.FX.Alexa.Common.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [HasType("AlexaSkillEvent.SkillPermissionChanged")]
    public class SkillPermissionChangedRequest : Request, ICoreRequest
    {
        [JsonProperty("body")]
        public PermissionBody Body { get; set; }
    }
}