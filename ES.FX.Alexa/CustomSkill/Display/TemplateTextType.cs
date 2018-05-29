using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public enum TemplateTextType
    {
        [EnumMember(Value = "PlainText")]
        PlainText,

        [EnumMember(Value = "RichText")]
        RichText
    }
}