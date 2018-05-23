using ES.FX.Alexa.SmartHomeSkill.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Discovery
{
    [DirectiveType("Alexa.Discovery", "Discover")]
    public class DiscoverDirective : DirectiveWithPayload<DiscoverDirectivePayload>
    {
    }
}