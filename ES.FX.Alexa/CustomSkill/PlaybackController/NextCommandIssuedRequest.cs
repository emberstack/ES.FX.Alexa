using ES.FX.Alexa.Json;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [HasType("PlaybackController.NextCommandIssued")]
    public class NextCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}