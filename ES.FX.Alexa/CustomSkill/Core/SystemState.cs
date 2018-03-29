using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class SystemState
    {
        [JsonProperty("apiAccessToken")]
        public string ApiAccessToken { get; set; }

        [JsonProperty("apiEndpoint")]
        public string ApiEndpoint { get; set; }

        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("device")]
        public Device Device { get; set; }
    }
}