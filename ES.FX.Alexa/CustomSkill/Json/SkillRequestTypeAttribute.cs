using System;

namespace ES.FX.Alexa.CustomSkill.Json
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class SkillRequestTypeAttribute : Attribute
    {
        public SkillRequestTypeAttribute(string type)
        {
            Type = type;
        }

        public string Type { get; }
    }
}