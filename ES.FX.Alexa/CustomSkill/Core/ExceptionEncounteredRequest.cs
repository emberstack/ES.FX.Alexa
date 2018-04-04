using ES.FX.Alexa.Common.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    [HasType("System.ExceptionEncountered")]
    public class ExceptionEncounteredRequest : Request, ICoreRequest
    {
        [JsonProperty("error")]
        public SystemError Error { get; set; }

        [JsonProperty("cause")]
        public SystemErrorCause Cause { get; set; }
    }
}