using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [SkillRequestType("LaunchRequest")]
    public class LaunchRequest : Request, ICoreRequest
    {

        [JsonProperty("shouldLinkResultBeReturned")]
        public bool ShouldLinkResultBeReturned { get; set; }
    }
}