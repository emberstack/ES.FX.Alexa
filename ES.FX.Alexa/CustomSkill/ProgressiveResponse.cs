using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class ProgressiveResponse
    {
        private readonly string _token;

        public ProgressiveResponse(string requestId, string token)
        {
            _token = token;
            Header = new ProgressiveResponseHeader {RequestId = requestId};
        }

        public ProgressiveResponse(Request request) :
            this(request.RequestId, request.Envelope.Context.System.ApiAccessToken)
        {
        }

        public ProgressiveResponse(SkillRequest request) :
            this(request.Request.RequestId, request.Context.System.ApiAccessToken)
        {
        }


        [JsonProperty("header")]
        public ProgressiveResponseHeader Header { get; set; }

        [JsonProperty("directive")]
        public VoicePlayerSpeakDirective Directive { get; set; }

        public async Task<bool> SendAsync()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _token);

                var httpResponse = await httpClient.PostAsync("https://api.amazonalexa.com/v1/directives",
                    new StringContent(JsonConvert.SerializeObject(this), Encoding.UTF8, "application/json"));

                return httpResponse.IsSuccessStatusCode;
            }
        }
    }
}