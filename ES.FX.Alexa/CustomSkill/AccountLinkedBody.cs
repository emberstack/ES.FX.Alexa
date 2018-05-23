using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class AccountLinkedBody
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}