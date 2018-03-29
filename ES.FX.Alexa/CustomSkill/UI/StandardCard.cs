using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.UI
{
    public class StandardCard : Card
    {
        public override string Type => "Standard";


        [JsonRequired]
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonRequired]
        [JsonProperty("text")]
        public string Content { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }
    }
}