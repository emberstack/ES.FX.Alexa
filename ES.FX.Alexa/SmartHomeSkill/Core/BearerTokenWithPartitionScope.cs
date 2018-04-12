using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    [HasType(ScopeType)]
    public class BearerTokenWithPartitionScope : Scope
    {
        public const string ScopeType = "BearerTokenWithPartition";
        public override string Type { get; set; } = ScopeType;

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("partition")]
        public string Partition { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}