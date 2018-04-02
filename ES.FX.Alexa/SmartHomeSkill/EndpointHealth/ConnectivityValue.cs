using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.EndpointHealth
{
    public class ConnectivityValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        public static implicit operator ConnectivityValue(string value)
        {
            return new ConnectivityValue {Value = value};
        }
    }
}
