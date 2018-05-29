using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Api.Models
{
    public class CountryAndPostalCode
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }
}
