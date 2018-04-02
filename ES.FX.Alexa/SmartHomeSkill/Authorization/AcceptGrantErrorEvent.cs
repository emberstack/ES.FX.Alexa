using ES.FX.Alexa.SmartHomeSkill.Core;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public class AcceptGrantErrorEvent : ErrorEvent
    {
        public AcceptGrantErrorEvent()
        {
            Header = new Header
            {
                Namespace = "Alexa.Authorization",
                Name = "ErrorResponse"
            };
            Payload.Type = "ACCEPT_GRANT_FAILED";
        }
    }
}