using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [SkillRequestType("AlexaSkillEvent.SkillAccountLinked")]
    public class SkillAccountLinkedRequest : Request, ICoreRequest
    {
        [JsonProperty("body")]
        public AccountLinkedBody Body { get; set; }
    }
}