using ES.FX.Alexa.Common.Json;
using ES.FX.Alexa.CustomSkill.Core;
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