using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public abstract class DisplayTemplate
    {
        [JsonProperty("type")]
        [JsonRequired]
        public abstract string Type { get; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("backButton")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BackButtonVisibility BackButton { get; set; }

        [JsonProperty("backgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateImage BackgroundImage { get; set; }
    }
}