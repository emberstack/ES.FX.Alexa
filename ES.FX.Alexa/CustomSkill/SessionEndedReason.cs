using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill
{
    public enum SessionEndedReason
    {
        [EnumMember(Value = "USER_INITIATED")]
        UserInitiated,

        [EnumMember(Value = "ERROR")]
        Error,

        [EnumMember(Value = "EXCEEDED_MAX_REPROMPTS")]
        ExceededMaxReprompts
    }
}