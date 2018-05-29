using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class ImageSource
    {
        [JsonProperty("url", Required = Required.Always)]
        public string Url { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        [JsonProperty("widthPixels")]
        public int Width { get; set; }

        [JsonProperty("heightPixels")]
        public int Height { get; set; }
    }
}