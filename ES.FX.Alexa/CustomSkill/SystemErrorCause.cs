using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class SystemErrorCause
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}