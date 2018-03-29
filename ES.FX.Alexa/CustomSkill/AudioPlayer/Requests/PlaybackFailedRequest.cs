using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer.Requests
{
    [SkillRequestType("AudioPlayer.PlaybackFailed")]
    public class PlaybackFailedRequest : Request, IAudioPlayerRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("currentPlaybackState")]
        public PlaybackState CurrentPlaybackState { get; set; }

        [JsonProperty("error")]
        public AudioPlayerError Error { get; set; }
    }
}