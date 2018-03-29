using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class SystemErrorCause
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}