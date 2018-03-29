using ES.FX.Alexa.CustomSkill.AudioPlayer.Requests;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core.Requests
{
    [SkillRequestType("System.ExceptionEncountered")]
    public class ExceptionEncounteredRequest : Request, IAudioPlayerRequest
    {
        [JsonProperty("error")]
        public SystemError Error { get; set; }

        [JsonProperty("cause")]
        public SystemErrorCause Cause { get; set; }
    }
}