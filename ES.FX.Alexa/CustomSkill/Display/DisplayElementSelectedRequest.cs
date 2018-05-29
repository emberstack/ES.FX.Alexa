using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    [HasType("Display.ElementSelected")]
    public class DisplayElementSelectedRequest : Request, IDisplayRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}