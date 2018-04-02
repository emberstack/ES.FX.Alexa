
using System;
using Newtonsoft.Json;

namespace ES.FX.Alexa.SmartHomeSkill.Core
{
    public class Event : InterfaceMessage
    {
        public Event()
        {
            Header = new Header
            {
                Name = "Response"
            };
        }
    }
}