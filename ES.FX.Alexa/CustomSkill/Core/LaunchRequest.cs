using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [HasType("LaunchRequest")]
    public class LaunchRequest : Request, ICoreRequest
    {
        [JsonProperty("shouldLinkResultBeReturned")]
        public bool ShouldLinkResultBeReturned { get; set; }
    }
}