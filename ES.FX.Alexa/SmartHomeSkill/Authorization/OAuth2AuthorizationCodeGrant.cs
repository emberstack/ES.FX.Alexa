using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    [HasType(GrantType)]
    public class OAuth2AuthorizationCodeGrant : Grant
    {
        public const string GrantType = "OAuth2.AuthorizationCode";
        public override string Type { get; set; } = GrantType;

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}