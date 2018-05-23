using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class DiscoverResponseEventPayload
    {
        [JsonProperty("endpoints")]
        public List<DiscoveryEndpoint> Endpoints { get; set; } = new List<DiscoveryEndpoint>();
    }
}