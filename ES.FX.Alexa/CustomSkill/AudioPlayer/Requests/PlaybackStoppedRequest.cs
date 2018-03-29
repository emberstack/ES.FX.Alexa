using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer.Requests
{
    [SkillRequestType("AudioPlayer.PlaybackStopped")]
    public class PlaybackStoppedRequest : Request, IAudioPlayerRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }
    }
}