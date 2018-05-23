using System;

namespace ES.FX.Alexa.SmartHomeSkill.Json
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class DirectiveTypeAttribute : Attribute
    {
        public DirectiveTypeAttribute(string @namespace, string name)
        {
            Namespace = @namespace;
            Name = name;
        }

        public string Namespace { get; }
        public string Name { get; }
    }
}