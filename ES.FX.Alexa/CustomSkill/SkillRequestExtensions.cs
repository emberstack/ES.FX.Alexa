using System.Threading.Tasks;
using ES.FX.Alexa.CustomSkill.Api;

namespace ES.FX.Alexa.CustomSkill
{
    public static class SkillRequestExtensions
    {
        public static Task<bool> SendProgressiveResponseAsync(this Request request, string speech)
        {
            return request.DirectivesApi().ProgressiveResponseAsync(new ProgressiveResponse(request)
            {
                Directive = {Speech = speech}
            });
        }

        public static Task<bool> SendProgressiveResponseAsync(this SkillRequest skillRequest, string speech)
        {
            return skillRequest.Request.SendProgressiveResponseAsync(speech);
        }


        public static DeviceApi DeviceApi(this Request request)
        {
            return new DeviceApi(request.Envelope.Context.System.Device.DeviceId,
                request.ApiHttpClient);
        }

        public static DeviceApi DeviceApi(this SkillRequest skillRequest)
        {
            return skillRequest.Request.DeviceApi();
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