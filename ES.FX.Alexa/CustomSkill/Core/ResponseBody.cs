using System.Collections.Generic;
using ES.FX.Alexa.CustomSkill.UI;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class ResponseBody
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public OutputSpeech OutputSpeech { get; set; }

        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Card Card { get; set; }

        [JsonProperty("reprompt", NullValueHandling = NullValueHandling.Ignore)]
        public Reprompt Reprompt { get; set; }

        [JsonProperty("shouldEndSession", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShouldEndSession { get; set; } = true;

        [JsonProperty("directives", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Directive> Directives { get; set; } = new List<Directive>();


        public static implicit operator ResponseBody(string value)
        {
            return new ResponseBody {OutputSpeech = new PlainTextOutputSpeech {Text = value}};
        }
    }
}