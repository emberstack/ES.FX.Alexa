using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class TemplateTextContent
    {
        [JsonProperty("primaryText", Required = Required.Always)]
        public TemplateText Primary { get; set; }

        [JsonProperty("secondaryText", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateText Secondary { get; set; }

        [JsonProperty("tertiaryText", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateText Tertiary { get; set; }
    }
}