using ES.FX.Alexa.CustomSkill.Core;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.VideoApp.Directives
{
    public class LaunchDirective : Directive
    {
        public override string Type => "VideoApp.Launch";

        [JsonProperty("videoItem", Required = Required.Always)]
        public VideoItem VideoItem { get; set; }
    }
}