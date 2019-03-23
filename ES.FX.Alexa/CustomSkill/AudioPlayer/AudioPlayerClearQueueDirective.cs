using ES.FX.Alexa.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    [HasType("AudioPlayer.ClearQueue")]
    public class AudioPlayerClearQueueDirective : Directive
    {
        public override string Type => "AudioPlayer.ClearQueue";

        [JsonProperty("clearBehavior")]
        [JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public ClearBehavior ClearBehavior { get; set; }
    }
}