namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class ChangeReportEvent : Event
    {
        public ChangeReportEvent()
        {
            Header = new Header
            {
                Name = "ChangeReport"
            };
        }
    }
}