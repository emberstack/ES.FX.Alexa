using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class Session
    {
        [JsonProperty("new")]
        public bool New { get; set; }


        [JsonProperty("sessionId")]
        public string SessionId { get; set; }


        [JsonProperty("attributes")]
        public Dictionary<string, dynamic> Attributes { get; set; } = new Dictionary<string, dynamic>();


        [JsonProperty("application")]
        public Application Application { get; set; }


        [JsonProperty("user")]
        public User User { get; set; }
    }
}