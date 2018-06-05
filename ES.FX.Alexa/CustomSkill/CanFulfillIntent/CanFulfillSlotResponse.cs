using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.CanFulfillIntent
{
    public class CanFulfillSlotResponse
    {
        [JsonProperty("canUnderstand")]
        public Capable CanUnderstand { get; set; }

        [JsonProperty("canFulfill")]
        public Capable CanFulfill { get; set; }
    }
}