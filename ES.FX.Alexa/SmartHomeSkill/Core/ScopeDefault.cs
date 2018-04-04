using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class ScopeDefault : Scope
    {
        public override string Type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }
    }
}