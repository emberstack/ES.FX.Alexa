using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class BodyTemplate2 : BodyTemplate
    {
        public override string Type => "BodyTemplate2";

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("textContent")]
        public TemplateTextContent TextContent { get; set; } = new TemplateTextContent();

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateImage Image { get; set; }
    }
}