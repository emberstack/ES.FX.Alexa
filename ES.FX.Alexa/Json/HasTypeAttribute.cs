using System;

namespace ES.FX.Alexa.Json
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class HasTypeAttribute : Attribute
    {
        public HasTypeAttribute(string type)
        {
            Type = type;
        }

        public string Type { get; }
    }
}