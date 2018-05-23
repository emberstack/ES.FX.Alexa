using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class CardImage
    {
        [JsonProperty("smallImageUrl")]
        [JsonRequired]
        public string SmallImageUrl { get; set; }

        [JsonProperty("largeImageUrl")]
        [JsonRequired]
        public string LargeImageUrl { get; set; }
    }
}