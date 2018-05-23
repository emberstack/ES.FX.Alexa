using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.EntityResolution
{
    public class Resolutions
    {
        [JsonProperty("resolutionsPerAuthority")]
        public Resolution[] ResolutionsPerAuthority { get; set; }
    }
}