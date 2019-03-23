using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    [HasType("Standard")]
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
        public CardImage Image { get; set; }
    }
}