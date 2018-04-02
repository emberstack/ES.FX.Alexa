using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Messaging
{
    [SkillRequestType("Messaging.MessageReceived")]
    public class MessageReceivedRequest : Request, IMessagingRequest
    {
        [JsonProperty("message")]
        public MessageBody Message { get; set; }
    }
}