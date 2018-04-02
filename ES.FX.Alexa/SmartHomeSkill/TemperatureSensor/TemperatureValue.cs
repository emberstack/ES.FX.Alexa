using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.TemperatureSensor
{
    public class TemperatureValue
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("scale")]
        public string Scale => "CELSIUS";

        public static implicit operator TemperatureValue(double value)
        {
            return new TemperatureValue {Value = value};
        }
    }
}