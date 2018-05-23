namespace ES.FX.Alexa.SmartHomeSkill
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