using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class Session
    {
        [JsonProperty("new")]
        public bool New { get; set; }


        [JsonProperty("sessionId")]
        public string SessionId { get; set; }


        //TODO: Provide better deserialization for the object. Most likely to a dynamic object
        [JsonProperty("attributes")]
        public Dictionary<string, object> Attributes { get; set; }


        [JsonProperty("application")]
        public Application Application { get; set; }


        [JsonProperty("user")]
        public User User { get; set; }
    }
}