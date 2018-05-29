using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Api
{
    public class DirectivesApi : SkillApi
    {
        public DirectivesApi(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<bool> ProgressiveResponseAsync(ProgressiveResponse progressiveResponse)
        {
            var response= await HttpClient.PostAsync("/v1/directives",
                new StringContent(JsonConvert.SerializeObject(progressiveResponse), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
    }
}