using System;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public abstract class StateReportProperty : Property
    {
        [JsonProperty("timeOfSample")]
        public DateTime TimeOfSample { get; set; } = DateTime.UtcNow;

        [JsonProperty("uncertaintyInMilliseconds")]
        public long UncertaintyInMilliseconds { get; set; } = 500;
    }
}