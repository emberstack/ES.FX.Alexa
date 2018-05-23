using ES.FX.Alexa.CustomSkill.EntityResolution;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill
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

        public override string ToString()
        {
            return $"{Name ?? "null"}={Value ?? "null"} [{ConfirmationStatus}]";
        }
    }
}