using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.EntityResolution
{
    public class Resolution
    {
        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("status")]
        public ResolutionStatus Status { get; set; }

        [JsonProperty("values")]
        public ResolutionValue[] Values { get; set; }
    }
}