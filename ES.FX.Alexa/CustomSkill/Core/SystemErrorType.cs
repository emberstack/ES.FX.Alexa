using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.Core
{
    public enum SystemErrorType
    {
        [EnumMember(Value = "INVALID_RESPONSE")]
        InvalidResponse,

        [EnumMember(Value = "DEVICE_COMMUNICATION_ERROR")]
        DeviceCommunicationError,

        [EnumMember(Value = "INTERNAL_SERVICE_ERROR")]
        InternalServiceError
    }
}