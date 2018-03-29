using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.EntityResolution
{
    public class Resolutions
    {
        [JsonProperty("resolutionsPerAuthority")]
        public Resolution[] ResolutionsPerAuthority { get; set; }
    }
}