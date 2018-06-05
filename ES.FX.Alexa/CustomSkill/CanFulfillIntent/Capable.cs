using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.CanFulfillIntent
{
    public enum Capable
    {
        [EnumMember(Value = "MAYBE")]
        Maybe,
        [EnumMember(Value = "YES")]
        Yes,
        [EnumMember(Value = "NO")]
        No
    }
}
