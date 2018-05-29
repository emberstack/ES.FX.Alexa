using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public class AudioPlayerError
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AudioPlayerErrorType Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}