using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [SkillRequestType("System.ExceptionEncountered")]
    public class ExceptionEncounteredRequest : Request, ICoreRequest
    {
        [JsonProperty("error")]
        public SystemError Error { get; set; }

        [JsonProperty("cause")]
        public SystemErrorCause Cause { get; set; }
    }
}