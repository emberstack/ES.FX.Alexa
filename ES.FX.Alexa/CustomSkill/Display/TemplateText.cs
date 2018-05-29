using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class TemplateText
    {
        [JsonProperty("text", Required = Required.Always)]
        public string Text { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateTextType Type { get; set; }

        public static implicit operator TemplateText(string text)
        {
            return new TemplateText
            {
                Type = TemplateTextType.RichText,
                Text = text
            };
        }
    }
}