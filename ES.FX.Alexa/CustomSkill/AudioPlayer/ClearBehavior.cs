using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public enum ClearBehavior
    {
        [EnumMember(Value = "CLEAR_ENQUEUED")] ClearEnqueued,
        [EnumMember(Value = "CLEAR_ALL")] ClearAll
    }
}