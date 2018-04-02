using ES.FX.Alexa.SmartHomeSkill.Core;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    public class AcceptGrantEvent : Event
    {
        public AcceptGrantEvent()
        {
            Header = new Header
            {
                Namespace = "Alexa.Authorization",
                Name = "AcceptGrant.Response"
            };
        }
    }
}