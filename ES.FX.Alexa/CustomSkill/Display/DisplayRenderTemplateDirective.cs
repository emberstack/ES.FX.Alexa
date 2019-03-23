using ES.FX.Alexa.Json;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    [HasType("Display.RenderTemplate")]
    public class DisplayRenderTemplateDirective : Directive
    {
        public override string Type => "Display.RenderTemplate";

        [JsonProperty("template", Required = Required.Always)]
        public DisplayTemplate Template { get; set; }
    }
}