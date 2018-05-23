using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill
{
    public class SystemError
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SystemErrorType Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}