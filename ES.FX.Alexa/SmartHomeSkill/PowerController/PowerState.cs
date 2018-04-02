using System.Runtime.Serialization;

namespace ES.FX.Alexa.SmartHomeSkill.PowerController
{
    public enum PowerState
    {
        [EnumMember(Value = "ON")]
        On,
        [EnumMember(Value = "OFF")]
        Off
    }
}