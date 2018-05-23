using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.EntityResolution
{
    public enum ResolutionStatusCode
    {
        [EnumMember(Value = "ER_SUCCESS_MATCH")]
        SuccessMatch,

        [EnumMember(Value = "ER_SUCCESS_NO_MATCH")]
        SuccessNoMatch,

        [EnumMember(Value = "ER_ERROR_TIMEOUT")]
        ErrorTimeout,

        [EnumMember(Value = "ER_ERROR_EXCEPTION")]
        ErrorException
    }
}