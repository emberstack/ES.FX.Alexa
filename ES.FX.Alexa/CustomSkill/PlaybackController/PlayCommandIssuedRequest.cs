using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Json;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [SkillRequestType("PlaybackController.PlayCommandIssued")]
    public class PlayCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}