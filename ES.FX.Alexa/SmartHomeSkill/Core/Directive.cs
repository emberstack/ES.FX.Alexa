namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class Directive : InterfaceMessage
    {
        public override string ToString()
        {
            return Header != null ? $"{Header.Namespace}.{Header.Name}" : base.ToString();
        }
    }
}