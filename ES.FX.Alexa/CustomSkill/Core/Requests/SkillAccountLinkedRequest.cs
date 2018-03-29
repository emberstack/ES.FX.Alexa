using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Requests
{
    [SkillRequestType("AlexaSkillEvent.SkillAccountLinked")]
    public class SkillAccountLinkedRequest : Request
    {
        [JsonProperty("body")]
        public AccountLinkedBody Body { get; set; }
    }
}