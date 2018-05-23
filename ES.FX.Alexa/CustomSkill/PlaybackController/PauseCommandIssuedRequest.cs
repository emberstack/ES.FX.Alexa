using ES.FX.Alexa.Json;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [HasType("PlaybackController.PauseCommandIssued")]
    public class PauseCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}