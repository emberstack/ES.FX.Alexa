using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class DiscoveryEndpoint
    {
        [JsonProperty("endpointId")]
        public string EndpointId { get; set; }

        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("manufacturerName")]
        public string ManufacturerName { get; set; }

        [JsonProperty("displayCategories")]
        public List<string> DisplayCategories { get; set; } = new List<string>();

        [JsonProperty("cookie")]
        public Dictionary<string, string> Cookies { get; set; } = new Dictionary<string, string>();

        [JsonProperty("capabilities")]
        public List<EndpointCapability> Capabilities { get; set; } = new List<EndpointCapability>();
    }
}