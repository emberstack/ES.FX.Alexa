using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill
{
    /// <summary>
    ///     Provides information about the application.
    /// </summary>
    public class Application
    {
        /// <summary>
        ///     A string representing the application ID for the skill.
        ///     This is used to verify that the request was intended for the service
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }
    }
}