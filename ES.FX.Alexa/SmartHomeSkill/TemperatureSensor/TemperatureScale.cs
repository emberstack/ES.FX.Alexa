using System.Runtime.Serialization;

namespace ES.FX.Alexa.SmartHomeSkill.TemperatureSensor
{
    public enum TemperatureScale
    {
        [EnumMember(Value = "CELSIUS")]
        Celsius,
        [EnumMember(Value = "FAHRENHEIT")]
        Fahrenheit,
        [EnumMember(Value = "KELVIN")]
        Kelvin
    }
}