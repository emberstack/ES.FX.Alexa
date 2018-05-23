using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public class PlayDirective : Directive
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