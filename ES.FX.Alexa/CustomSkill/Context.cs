using ES.FX.Alexa.CustomSkill.AudioPlayer;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class Context
    {
        [JsonProperty("System")]
        public SystemState System { get; set; }

        [JsonProperty("AudioPlayer")]
        public AudioPlayerState AudioPlayer { get; set; }
    }
}