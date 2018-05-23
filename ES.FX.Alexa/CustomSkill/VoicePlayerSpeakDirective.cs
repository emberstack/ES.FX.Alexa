using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    [HasType("VoicePlayer.Speak")]
    public class VoicePlayerSpeakDirective : Directive
    {
        public override string Type { get; } = "VoicePlayer.Speak";

        [JsonProperty("speech")]
        public string Speech { get; set; }
    }
}