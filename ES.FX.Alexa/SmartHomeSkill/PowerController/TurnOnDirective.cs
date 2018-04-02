using ES.FX.Alexa.SmartHomeSkill.Core;
using ES.FX.Alexa.SmartHomeSkill.Json;

namespace ES.FX.Alexa.SmartHomeSkill.PowerController
{
    [DirectiveType("Alexa.PowerController", "TurnOn")]
    public class TurnOnDirective : Directive, IPowerControllerDirective
    {
    }
}