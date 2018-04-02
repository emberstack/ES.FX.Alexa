using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Json;

namespace ES.FX.Alexa.CustomSkill.PlaybackController
{
    [SkillRequestType("PlaybackController.PauseCommandIssued")]
    public class PauseCommandIssuedRequest : Request, IPlaybackControllerRequest
    {
    }
}