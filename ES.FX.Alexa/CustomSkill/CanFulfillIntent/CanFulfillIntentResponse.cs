using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.CanFulfillIntent
{
    public class CanFulfillIntentResponse
    {
        [JsonProperty("canFulfill")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Capable CanFulfill { get; set; }

        [JsonProperty("slots")]
        public Dictionary<string, CanFulfillSlotResponse> Slots { get; set; } = new Dictionary<string, CanFulfillSlotResponse>();
    }
}