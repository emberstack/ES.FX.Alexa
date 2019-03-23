using System.Collections.Generic;
using ES.FX.Alexa.CustomSkill.CanFulfillIntent;
using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class ResponseBody
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(WithTypeConverter<OutputSpeech, OutputSpeechDefault>))]
        public OutputSpeech OutputSpeech { get; set; }

        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(WithTypeConverter<Card, CardDefault>))]
        public Card Card { get; set; }

        [JsonProperty("reprompt", NullValueHandling = NullValueHandling.Ignore)]
        public Reprompt Reprompt { get; set; }

        [JsonProperty("shouldEndSession", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShouldEndSession { get; set; }

        [JsonProperty("directives", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Directive> Directives { get; set; } = new List<Directive>();

        [JsonProperty("canFulfillIntent", NullValueHandling = NullValueHandling.Ignore)]
        public CanFulfillIntentResponse CanFulfillIntent { get; set; }
    }
}