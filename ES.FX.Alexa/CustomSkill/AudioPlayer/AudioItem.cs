using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public class AudioItem
    {
        [JsonRequired]
        [JsonProperty("stream")]
        public AudioItemStream Stream { get; set; }
    }
}