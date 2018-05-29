using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public enum AudioPlayerErrorType
    {
        [EnumMember(Value = "MEDIA_ERROR_INTERNAL_DEVICE_ERROR")]
        MediaErrorInternalDeviceError,

        [EnumMember(Value = "MEDIA_ERROR_INTERNAL_SERVER_ERROR")]
        MediaErrorInternalServerError,

        [EnumMember(Value = "MEDIA_ERROR_INVALID_REQUEST")]
        MediaErrorInvalidRequest,

        [EnumMember(Value = "MEDIA_ERROR_SERVICE_UNAVAILABLE")]
        MediaErrorServiceUnavailable,

        [EnumMember(Value = "MEDIA_ERROR_UNKNOWN")]
        MediaErrorUnknown
    }
}