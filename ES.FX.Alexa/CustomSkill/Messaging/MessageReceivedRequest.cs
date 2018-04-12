using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Messaging
{
    [HasType("Messaging.MessageReceived")]
    public class MessageReceivedRequest : Request, IMessagingRequest
    {
        [JsonProperty("message")]
        public MessageBody Message { get; set; }
    }
}