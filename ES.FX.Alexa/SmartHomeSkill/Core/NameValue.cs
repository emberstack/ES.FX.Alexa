using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class NameValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public static implicit operator NameValue(string value)
        {
            return new NameValue {Name = value};
        }
    }
}