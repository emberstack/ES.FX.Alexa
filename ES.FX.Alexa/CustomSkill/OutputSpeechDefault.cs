using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.CustomSkill
{
    public class OutputSpeechDefault : OutputSpeech
    {
        public override string Type { get; }

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }
    }
}