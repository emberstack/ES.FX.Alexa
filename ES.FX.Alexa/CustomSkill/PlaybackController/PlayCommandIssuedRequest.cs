using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.Json;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [HasType("PlaybackController.PlayCommandIssued")]
    public class PlayCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}