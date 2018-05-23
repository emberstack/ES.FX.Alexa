using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class SkillResponse
    {
        [JsonRequired]
        [JsonProperty("version")]
        public string Version { get; set; } = "1.0";

        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> SessionAttributes { get; set; } = new Dictionary<string, dynamic>();

        [JsonRequired]
        [JsonProperty("response")]
        public ResponseBody Response { get; set; } = new ResponseBody();
    }
}