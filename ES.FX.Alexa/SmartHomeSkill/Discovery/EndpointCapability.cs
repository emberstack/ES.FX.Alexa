using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class EndpointCapability
    {
        [JsonProperty("type")]
        public string Type { get; set; } = "AlexaInterface";

        [JsonProperty("interface")]
        public string Interface { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; } = "3";

        [JsonProperty("properties")]
        public CapabilityProperties Properties { get; set; }

        [JsonProperty("supportsDeactivation")]
        public bool? SupportsDeactivation { get; set; }

        [JsonProperty("proactivelyReported")]
        public bool? ProactivelyReported { get; set; }

        [JsonProperty("cameraStreamConfigurations")]
        public List<CameraStreamConfiguration> CameraStreamConfigurations { get; set; }
    }
}