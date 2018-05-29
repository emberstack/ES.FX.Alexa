using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class BodyTemplate1 : BodyTemplate
    {
        public override string Type => "BodyTemplate1";

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("textContent")]
        public TemplateTextContent TextContent { get; set; } = new TemplateTextContent();
    }
}