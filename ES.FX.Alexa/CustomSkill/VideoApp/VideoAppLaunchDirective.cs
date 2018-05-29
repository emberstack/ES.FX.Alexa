using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.VideoApp
{
    public class VideoAppLaunchDirective : Directive
    {
        public override string Type => "VideoApp.Launch";

        [JsonProperty("videoItem", Required = Required.Always)]
        public VideoItem VideoItem { get; set; } = new VideoItem();
    }
}