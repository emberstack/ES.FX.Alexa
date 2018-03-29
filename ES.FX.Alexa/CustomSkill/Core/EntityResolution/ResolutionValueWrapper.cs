using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.EntityResolution
{
    public class ResolutionValueWrapper
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}