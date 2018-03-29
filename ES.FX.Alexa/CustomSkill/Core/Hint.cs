using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class Hint
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}