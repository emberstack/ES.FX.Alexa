using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill
{
    public enum ConfirmationStatus
    {
        [EnumMember(Value = "NONE")]
        None,

        [EnumMember(Value = "CONFIRMED")]
        Confirmed,

        [EnumMember(Value = "DENIED")]
        Denied
    }
}