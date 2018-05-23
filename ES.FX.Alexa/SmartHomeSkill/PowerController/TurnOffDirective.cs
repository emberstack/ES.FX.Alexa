using ES.FX.Alexa.SmartHomeSkill.Json;

namespace ES.FX.Alexa.SmartHomeSkill.PowerController
{
    [DirectiveType("Alexa.PowerController", "TurnOff")]
    public class TurnOffDirective : Directive, IPowerControllerDirective
    {
    }
}