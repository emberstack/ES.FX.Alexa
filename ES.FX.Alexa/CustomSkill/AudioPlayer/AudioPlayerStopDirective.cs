using ES.FX.Alexa.Json;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{

    [HasType("AudioPlayer.Stop")]
    public class AudioPlayerStopDirective : Directive
    {
        public override string Type => "AudioPlayer.Stop";
    }
}