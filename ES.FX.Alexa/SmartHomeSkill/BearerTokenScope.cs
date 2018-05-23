using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
{
    [HasType(ScopeType)]
    public class BearerTokenScope : Scope
    {
        public const string ScopeType = "BearerToken";
        public override string Type { get; set; } = ScopeType;

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}