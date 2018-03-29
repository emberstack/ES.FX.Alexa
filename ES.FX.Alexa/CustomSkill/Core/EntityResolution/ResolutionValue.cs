using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.EntityResolution
{
    public class ResolutionValue
    {
        [JsonProperty("value")]
        public ResolutionValueWrapper Value { get; set; }
    }
}