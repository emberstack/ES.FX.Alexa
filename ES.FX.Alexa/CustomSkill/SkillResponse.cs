using System.Collections.Generic;
using ES.FX.Alexa.CustomSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class SkillResponse
    {
        [JsonRequired]
        [JsonProperty("version")]
        public string Version { get; set; } = "1.0";

        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes { get; set; }

        [JsonRequired]
        [JsonProperty("response")]
        public ResponseBody Response { get; set; } = new ResponseBody();
    }
}