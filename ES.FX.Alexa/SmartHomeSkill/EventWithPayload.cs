using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class EventWithPayload<TPayload> : Event where TPayload : new()
    {
        [JsonProperty("payload")]
        public TPayload Payload { get; set; } = new TPayload();
    }
}