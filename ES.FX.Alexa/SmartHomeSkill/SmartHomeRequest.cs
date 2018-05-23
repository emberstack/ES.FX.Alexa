using ES.FX.Alexa.SmartHomeSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public class SmartHomeRequest
    {
        [JsonProperty("directive")]
        [JsonConverter(typeof(DirectiveConverter))]
        public Directive Directive { get; set; }
    }
}