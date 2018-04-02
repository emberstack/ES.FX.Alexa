using ES.FX.Alexa.SmartHomeSkill.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.SmartHomeSkill.PowerController
{
    public class PowerStateReportProperty : StateReportProperty
    {
        public override string Namespace => "Alexa.PowerController";
        public override string Name => "powerState";

        [JsonProperty("value")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PowerState Value { get; set; }
    }
}