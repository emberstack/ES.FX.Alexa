using ES.FX.Alexa.Json;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [HasType("PlaybackController.PreviousCommandIssued")]
    public class PreviousCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}