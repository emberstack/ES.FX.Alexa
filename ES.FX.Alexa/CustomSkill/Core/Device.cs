using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class Device
    {
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        //TODO: Provide better deserialization for the object. Most likely to a dynamic object
        [JsonProperty("supportedInterfaces")]
        public Dictionary<string, dynamic> SupportedInterfaces { get; set; }
    }
}