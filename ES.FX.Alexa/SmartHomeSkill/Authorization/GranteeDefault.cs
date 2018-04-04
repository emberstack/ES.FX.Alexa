using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public class GranteeDefault : Grantee
    {
        public override string Type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }
    }
}