using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.Common.Json
{
    public class WithTypeConverter<TBaseType, TDefaultType> : JsonConverter where TDefaultType : TBaseType, new()
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TBaseType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jobject = JObject.Load(reader);
            string requestType = null;
            if (jobject.ContainsKey("type")) requestType = jobject["type"].Value<string>();

            var match = Assembly.GetExecutingAssembly().GetTypes()
                .Select(type => new {type, attributes = type.GetCustomAttributes(typeof(HasTypeAttribute), true)})
                .Where(t =>
                    t.attributes != null &&
                    t.attributes.OfType<HasTypeAttribute>().Any(a => a.Type == requestType))
                .Select(t => t.type).FirstOrDefault();

            if (match == null) match = typeof(TDefaultType);
            var instance = Activator.CreateInstance(match);
            serializer.Populate(jobject.CreateReader(), instance);
            return instance;
        }
    }
}