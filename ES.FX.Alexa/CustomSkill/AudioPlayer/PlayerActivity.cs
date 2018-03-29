using System.Runtime.Serialization;

namespace ES.FX.Alexa.CustomSkill.AudioPlayer
{
    public enum PlayerActivity
    {
        [EnumMember(Value = "PLAYING")] Playing,
        [EnumMember(Value = "PAUSED")] Paused,
        [EnumMember(Value = "FINISHED")] Finished,

        [EnumMember(Value = "BUFFER_UNDERRUN")]
        BufferUnderrun,
        [EnumMember(Value = "IDLE")] Idle,
        [EnumMember(Value = "STOPPED")] Stopped
    }
}