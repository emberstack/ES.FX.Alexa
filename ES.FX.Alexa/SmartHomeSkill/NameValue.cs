using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill
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