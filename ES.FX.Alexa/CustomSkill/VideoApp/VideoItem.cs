using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.VideoApp
{
    public class VideoItem
    {
        [JsonProperty("source", Required = Required.Always)]
        public string Source { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VideoItemMetadata Metadata { get; set; }
    }
}