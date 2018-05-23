using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class CameraStreamConfiguration
    {
        [JsonProperty("protocols")]
        public List<string> Protocols { get; set; }

        [JsonProperty("resolutions")]
        public List<CameraStreamResolution> Resolutions { get; set; }

        [JsonProperty("authorizationTypes")]
        public List<string> AuthorizationTypes { get; set; }

        [JsonProperty("videoCodecs")]
        public List<string> VideoCodecs { get; set; }

        [JsonProperty("audioCodecs")]
        public List<string> AudioCodecs { get; set; }
    }
}