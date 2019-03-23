using ES.FX.Alexa.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    [HasType("AudioPlayer.Play")]
    public class AudioPlayerPlayDirective : Directive
    {
        public override string Type => "AudioPlayer.Play";


        [JsonProperty("playBehavior")]
        [JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public PlayBehavior PlayBehavior { get; set; }

        [JsonProperty("audioItem")]
        [JsonRequired]
        public AudioItem AudioItem { get; set; }
    }
}