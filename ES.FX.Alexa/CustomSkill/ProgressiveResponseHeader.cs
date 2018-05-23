using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class ProgressiveResponseHeader
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}