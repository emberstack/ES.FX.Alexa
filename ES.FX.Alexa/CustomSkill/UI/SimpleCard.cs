using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.UI
{
    public class SimpleCard : Card
    {
        public override string Type => "Simple";


        [JsonProperty("title")]
        [JsonRequired]
        public string Title { get; set; }

        [JsonRequired]
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}