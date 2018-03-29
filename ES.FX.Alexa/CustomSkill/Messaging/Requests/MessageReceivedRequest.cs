using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Messaging.Requests
{
    [SkillRequestType("Messaging.MessageReceived")]
    public class MessageReceivedRequest : Request
    {
        [JsonProperty("message")]
        public MessageBody Message { get; set; }
    }
}