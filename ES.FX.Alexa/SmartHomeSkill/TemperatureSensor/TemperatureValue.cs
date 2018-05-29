using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.SmartHomeSkill.TemperatureSensor
{
    public class TemperatureValue
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("scale")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemperatureScale Scale { get; set; } = TemperatureScale.Celsius;

        public static implicit operator TemperatureValue(double value)
        {
            return new TemperatureValue {Value = value};
        }
    }
}