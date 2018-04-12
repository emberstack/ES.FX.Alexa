using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    [HasType("AudioPlayer.PlaybackStarted")]
    public class PlaybackStartedRequest : Request, IAudioPlayerRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }
    }
}