using System.Text;
using System.Threading.Tasks;
using ES.FX.Alexa.CustomSkill.Api;

namespace ES.FX.Alexa.CustomSkill
{
    public static class SkillRequestExtensions
    {
        public static Task<bool> PostProgressiveResponseAsync(this Request request, string speech)
        {
            return request.DirectivesApi().PostProgressiveResponseAsync(new ProgressiveResponse(request)
            {
                Directive = {Speech = speech}
            });
        }

        public static Task<bool> PostProgressiveResponseAsync(this SkillRequest skillRequest, string speech)
        {
            return skillRequest.Request.PostProgressiveResponseAsync(speech);
        }

        public static Task<bool> PostProgressiveResponseAsync(this Request request, StringBuilder speechBuilder)
        {
            return request.DirectivesApi().PostProgressiveResponseAsync(new ProgressiveResponse(request)
            {
                Directive = {Speech = speechBuilder.ToString()}
            });
        }

        public static Task<bool> PostProgressiveResponseAsync(this SkillRequest skillRequest,
            StringBuilder speechBuilder)
        {
            return skillRequest.Request.PostProgressiveResponseAsync(speechBuilder);
        }


        public static DevicesApi DevicesApi(this Request request)
        {
            return new DevicesApi(request.Envelope.Context.System.Device.DeviceId,
                request.ApiHttpClient);
        }

        public static DevicesApi DevicesApi(this SkillRequest skillRequest)
        {
            return skillRequest.Request.DevicesApi();
        }

        public static DirectivesApi DirectivesApi(this Request request)
        {
            return new DirectivesApi(request.ApiHttpClient);
        }

        public static DirectivesApi DirectivesApi(this SkillRequest skillRequest)
        {
            return skillRequest.Request.DirectivesApi();
        }
    }
}