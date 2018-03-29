using System;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public class UserPermissions
    {
        [JsonProperty("consentToken")]
        [Obsolete]
        public string ConsentToken { get; set; }
    }
}