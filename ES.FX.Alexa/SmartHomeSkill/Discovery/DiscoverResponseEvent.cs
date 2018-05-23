namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    public class DiscoverResponseEvent : EventWithPayload<DiscoverResponseEventPayload>
    {
        public DiscoverResponseEvent()
        {
            Header = new Header
            {
                Namespace = "Alexa.Discovery",
                Name = "Discover.Response"
            };
        }
    }
}