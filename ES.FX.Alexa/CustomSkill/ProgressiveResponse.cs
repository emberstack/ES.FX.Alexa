using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class ProgressiveResponse
    {
        public ProgressiveResponse()
        {

        }
        public ProgressiveResponse(string requestId)
        {
            Header = new ProgressiveResponseHeader {RequestId = requestId};
        }

        public ProgressiveResponse(Request request) :
            this(request.RequestId)
        {
        }

        public ProgressiveResponse(SkillRequest request) :
            this(request.Request.RequestId)
        {
        }


        [JsonProperty("header")]
        public ProgressiveResponseHeader Header { get; set; } = new ProgressiveResponseHeader();

        [JsonProperty("directive")]
        public VoicePlayerSpeakDirective Directive { get; set; } = new VoicePlayerSpeakDirective();
    }
}