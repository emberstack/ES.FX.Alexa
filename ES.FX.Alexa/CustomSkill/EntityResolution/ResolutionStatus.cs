using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.EntityResolution
{
    public class ResolutionStatus
    {
        [JsonProperty("code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ResolutionStatusCode Code { get; set; }
    }
}