using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using ES.FX.Alexa.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.CustomSkill
{
    public class SkillRequest
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("session")]
        public Session Session { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }

        [JsonProperty("request")]
        [JsonConverter(typeof(WithTypeConverter<Request, RequestDefault>))]
        public Request Request { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> JsonExtensionData { get; set; }

        /// <summary>
        ///     Provides <see cref="HttpClient" /> with authentication and endpoint set for this request.
        /// </summary>
        [JsonIgnore]
        public HttpClient ApiHttpClient { get; internal set; }


        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            if (Request == null) return;
            Request.Envelope = new RequestEnvelope
            {
                Version = Version,
                Session = Session,
                Context = Context
            };
            ApiHttpClient = new HttpClient
            {
                BaseAddress = new Uri(Context.System.ApiEndpoint.EndsWith("/")
                    ? Context.System.ApiEndpoint
                    : $"{Context.System.ApiEndpoint}/")
            };
            ApiHttpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Context.System.ApiAccessToken);
            Request.ApiHttpClient = ApiHttpClient;
        }
    }
}