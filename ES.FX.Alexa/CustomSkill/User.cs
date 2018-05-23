using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class User
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("permissions")]
        public UserPermissions Permissions { get; set; }
    }
}