using System.Threading.Tasks;

namespace ES.FX.Alexa.CustomSkill
{
    public static class SkillRequestExtensions
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