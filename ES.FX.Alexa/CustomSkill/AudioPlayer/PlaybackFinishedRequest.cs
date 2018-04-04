using ES.FX.Alexa.Common.Json;
using ES.FX.Alexa.CustomSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    [HasType("AudioPlayer.PlaybackFinished")]
    public class PlaybackFinishedRequest : Request, IAudioPlayerRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }
    }
}