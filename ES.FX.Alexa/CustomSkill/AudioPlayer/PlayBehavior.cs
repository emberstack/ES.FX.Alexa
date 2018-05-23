using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public enum PlayBehavior
    {
        [EnumMember(Value = "ENQUEUE")]
        Enqueue,

        [EnumMember(Value = "REPLACE_ALL")]
        ReplaceAll,

        [EnumMember(Value = "REPLACE_ENQUEUED")]
        ReplaceEnqueued
    }
}