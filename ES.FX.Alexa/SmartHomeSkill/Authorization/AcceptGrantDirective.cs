using ES.FX.Alexa.SmartHomeSkill.Core;
using ES.FX.Alexa.SmartHomeSkill.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Authorization
{
    [DirectiveType("Alexa.Authorization", "AcceptGrant")]
    public class AcceptGrantDirective : DirectiveWithPayload<AcceptGrantDirectivePayload>
    {
    }
}