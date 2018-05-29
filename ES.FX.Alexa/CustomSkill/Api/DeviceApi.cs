using System.Net.Http;
using System.Threading.Tasks;
using ES.FX.Alexa.CustomSkill.Api.Models;

namespace ES.FX.Alexa.CustomSkill.Api
{
    public class DeviceApi : SkillApi
    {
        public DeviceApi(string deviceId, HttpClient httpClient) : base(httpClient)
        {
            DeviceId = deviceId;
        }

        public string DeviceId { get; }

        public Task<CountryAndPostalCode> GetCountryAndPostalCodeAsync()
        {
            return GetAsync<CountryAndPostalCode>($"v1/devices/{DeviceId}/settings/address/countryAndPostalCode");
        }

        public Task<Address> GetAddressAsync()
        {
            return GetAsync<Address>($"v1/devices/{DeviceId}/settings/address");
        }
    }
}