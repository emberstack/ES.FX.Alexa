using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.UI
{
    public class Image
    {
        [JsonProperty("smallImageUrl")]
        [JsonRequired]
        public string SmallImageUrl { get; set; }

        [JsonProperty("largeImageUrl")]
        [JsonRequired]
        public string LargeImageUrl { get; set; }
    }
}