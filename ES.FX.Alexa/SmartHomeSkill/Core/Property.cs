using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public abstract class Property
    {
        [JsonProperty("namespace")]
        public abstract string Namespace { get; }

        [JsonProperty("name")]
        public abstract string Name { get; }
    }
}
