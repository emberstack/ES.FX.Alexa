using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public enum BackButtonVisibility
    {
        [EnumMember(Value = "VISIBLE")]
        Visibile,

        [EnumMember(Value = "HIDDEN")]
        Hidden
    }
}