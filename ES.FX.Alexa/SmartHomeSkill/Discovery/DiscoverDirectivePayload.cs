using ES.FX.Alexa.SmartHomeSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class DiscoverDirectivePayload
    {
        [JsonProperty("scope")]
        public TypedToken Scope { get; set; }
    }
}