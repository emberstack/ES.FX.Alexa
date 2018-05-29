using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class BodyTemplate7 : BodyTemplate
    {
        public override string Type => "BodyTemplate7";

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateImage Image { get; set; }
    }
}