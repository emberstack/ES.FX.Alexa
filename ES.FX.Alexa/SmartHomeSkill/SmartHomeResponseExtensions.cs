using System;
using System.Collections.Generic;
using System.Text;

namespace ES.FX.Alexa.SmartHomeSkill
{
    public static class SmartHomeResponseExtensions
    {
        public static SmartHomeResponse WithEvent<TEvent>(this SmartHomeResponse response, TEvent instance, Action<TEvent> configure = null) where TEvent : Event
        {
            response.Event = instance ?? throw new ArgumentNullException(nameof(instance));
            configure?.Invoke(instance);
            return response;
        }

        public static SmartHomeResponse WithEvent<TEvent>(this SmartHomeResponse response, Action<TEvent> configure = null) where TEvent : Event, new()
        {
            return response.WithEvent(new TEvent(), configure);
        }


        public static SmartHomeResponse WithContext(this SmartHomeResponse response, Context instance, Action<Context> configure = null)
        {
            response.Context = instance ?? throw new ArgumentNullException(nameof(instance));
            configure?.Invoke(instance);
            return response;
        }

        public static SmartHomeResponse WithContext(this SmartHomeResponse response, Action<Context> configure = null)
        {
            return response.WithContext(new Context(), configure);
        }
    }
}
