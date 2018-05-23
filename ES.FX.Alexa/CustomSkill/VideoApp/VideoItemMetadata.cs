using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.VideoApp
{
    public class VideoItemMetadata
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }
    }
}