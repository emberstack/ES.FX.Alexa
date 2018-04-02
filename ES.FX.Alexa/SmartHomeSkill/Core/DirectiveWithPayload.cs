using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class DirectiveWithPayload<TPayload> : Directive where TPayload : new()
    {
        [JsonProperty("payload")]
        public TPayload Payload { get; set; } = new TPayload();
    }
}