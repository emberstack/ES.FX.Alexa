using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.EndpointHealth
{
    public class ConnectivityReportProperty : StateReportProperty
    {
        public override string Namespace => "Alexa.EndpointHealth";
        public override string Name => "connectivity";

        [JsonProperty("value")]
        public ConnectivityValue Value { get; set; } = new ConnectivityValue();
    }
}