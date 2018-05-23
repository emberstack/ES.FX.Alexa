using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class Device
    {
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("supportedInterfaces")]
        public Dictionary<string, dynamic> SupportedInterfaces { get; set; }
    }
}