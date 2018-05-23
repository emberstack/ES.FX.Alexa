using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public class AcceptGrantDirectivePayload
    {
        [JsonConverter(typeof(WithTypeConverter<Grant, GrantDefault>))]
        [JsonProperty("grant")]
        public Grant Grant { get; set; }

        [JsonConverter(typeof(WithTypeConverter<Grantee, GranteeDefault>))]
        [JsonProperty("grantee")]
        public Grantee Grantee { get; set; }
    }
}