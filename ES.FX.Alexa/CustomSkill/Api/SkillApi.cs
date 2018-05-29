using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Api
{
    public abstract class SkillApi
    {
        protected SkillApi(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected HttpClient HttpClient { get; }

        protected async Task<T> GetAsync<T>(string resourceUrl, bool tryGet = true)
        {
            var response = await HttpClient.GetAsync(resourceUrl);
            if (!tryGet) response.EnsureSuccessStatusCode();
            if (!response.IsSuccessStatusCode) return default(T);
            var rawContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(rawContent);
        }
    }
}