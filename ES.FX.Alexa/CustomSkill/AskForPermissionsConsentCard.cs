using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class AskForPermissionsConsentCard : Card
    {
        public override string Type => "AskForPermissionsConsent";

        [JsonProperty("permissions")]
        [JsonRequired]
        public List<string> Permissions { get; set; } = new List<string>();
    }
}