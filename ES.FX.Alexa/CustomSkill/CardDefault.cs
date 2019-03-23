using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.CustomSkill
{
    public class CardDefault : Card
    {
        public override string Type => nameof(CardDefault);

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }
    }
}