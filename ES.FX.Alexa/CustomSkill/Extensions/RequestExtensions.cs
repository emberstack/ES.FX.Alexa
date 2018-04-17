using System.Threading.Tasks;
using ES.FX.Alexa.CustomSkill.Core;

namespace ES.FX.Alexa.CustomSkill.Extensions
{
    public static class RequestExtensions
    {
        public static Task<bool> SendProgressiveResponseAsync(this Request request, string speech)
        {
            return new ProgressiveResponse(request)
            {
                Directive = new VoicePlayerSpeakDirective
                {
                    Speech = speech
                }
            }.SendAsync();
        }

        public static Task<bool> SendProgressiveResponseAsync(this SkillRequest request, string speech)
        {
            return new ProgressiveResponse(request)
            {
                Directive = new VoicePlayerSpeakDirective
                {
                    Speech = speech
                }
            }.SendAsync();
        }
    }
}
