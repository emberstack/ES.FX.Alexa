using ES.FX.Alexa.Common.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [HasType("AlexaSkillEvent.SkillAccountLinked")]
    public class SkillAccountLinkedRequest : Request, ICoreRequest
    {
        [JsonProperty("body")]
        public AccountLinkedBody Body { get; set; }
    }
}