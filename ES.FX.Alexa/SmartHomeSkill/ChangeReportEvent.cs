namespace ES.FX.Alexa.SmartHomeSkill
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