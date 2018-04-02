using ES.FX.Alexa.CustomSkill.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public class ClearQueueDirective : Directive
    {
        public override string Type => "AudioPlayer.ClearQueue";

        [JsonProperty("clearBehavior")]
        [JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public ClearBehavior ClearBehavior { get; set; }
    }
}