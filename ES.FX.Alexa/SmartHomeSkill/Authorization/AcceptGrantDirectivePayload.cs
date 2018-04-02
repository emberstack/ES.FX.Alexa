using ES.FX.Alexa.SmartHomeSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public class AcceptGrantDirectivePayload
    {
        [JsonProperty("grant")]
        public TypedCode Grant { get; set; }

        [JsonProperty("grantee")]
        public TypedToken Grantee { get; set; }
    }
}