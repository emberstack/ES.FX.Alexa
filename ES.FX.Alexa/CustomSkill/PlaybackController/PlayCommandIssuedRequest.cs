using ES.FX.Alexa.Common.Json;
using ES.FX.Alexa.CustomSkill.Core;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [HasType("PlaybackController.PlayCommandIssued")]
    public class PlayCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}