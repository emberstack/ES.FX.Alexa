using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class ListItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("image")]
        public TemplateImage Image { get; set; }

        [JsonProperty("textContent")]
        public TemplateTextContent TextContent { get; set; } = new TemplateTextContent();
    }
}