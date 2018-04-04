using ES.FX.Alexa.Common.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    [HasType(GranteeType)]
    public class BearerTokenGrantee : Grantee
    {
        public const string GranteeType = "BearerToken";
        public override string Type { get; set; } = GranteeType;

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}