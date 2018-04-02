namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class ErrorEvent : EventWithPayload<ErrorPayload>
    {
        public ErrorEvent()
        {
            Header = new Header
            {
                Name = "ErrorResponse"
            };
        }
    }
}