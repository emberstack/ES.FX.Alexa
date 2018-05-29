using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class BodyTemplate6 : BodyTemplate
    {
        public override string Type => "BodyTemplate3";

        [JsonProperty("textContent")]
        public TemplateTextContent TextContent { get; set; } = new TemplateTextContent();

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateImage Image { get; set; }
    }
}