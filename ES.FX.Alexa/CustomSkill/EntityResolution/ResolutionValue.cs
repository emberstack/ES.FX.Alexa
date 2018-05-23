using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.EntityResolution
{
    public class ResolutionValue
    {
        [JsonProperty("value")]
        public ResolutionValueWrapper Value { get; set; }
    }
}