using System.Runtime.Serialization;
using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.Json;
using Newtonsoft.Json;

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

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            if (Request != null)
                Request.Envelope = new RequestEnvelope
                {
                    Version = Version,
                    Session = Session,
                    Context = Context
                };
        }
    }
}