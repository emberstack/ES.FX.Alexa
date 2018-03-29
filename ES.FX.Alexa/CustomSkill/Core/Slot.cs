using ES.FX.Alexa.CustomSkill.Core.EntityResolution;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class Slot
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confirmationStatus", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConfirmationStatus ConfirmationStatus { get; set; }

        [JsonProperty("resolutions", NullValueHandling = NullValueHandling.Ignore)]
        public Resolutions Resolutions { get; set; }
    }
}