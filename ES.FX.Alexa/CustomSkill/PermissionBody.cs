using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    public class PermissionBody
    {
        [JsonProperty("acceptedPermissions")]
        public Permission[] AcceptedPermissions { get; set; }
    }
}