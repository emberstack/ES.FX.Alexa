using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public class DisplayRenderTemplateDirective : Directive
    {
        public override string Type => "Display.RenderTemplate";

        [JsonProperty("template", Required = Required.Always)]
        public DisplayTemplate Template { get; set; }
    }
}