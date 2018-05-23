using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.SmartHomeSkill.Json
{
    public class DirectiveConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Directive);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jobject = JObject.Load(reader);
            var directiveNamespace = jobject["header"]["namespace"].Value<string>();
            var directiveName = jobject["header"]["name"].Value<string>();

            var match = Assembly.GetExecutingAssembly().GetTypes()
                .Select(type => new {type, attributes = type.GetCustomAttributes(typeof(DirectiveTypeAttribute), true)})
                .Where(t =>
                    t.attributes != null &&
                    t.attributes.OfType<DirectiveTypeAttribute>()
                        .Any(a => a.Namespace == directiveNamespace && a.Name == directiveName))
                .Select(t => t.type).FirstOrDefault();

            if (match == null) match = typeof(UnknownDirective);
            var instance = Activator.CreateInstance(match);
            serializer.Populate(jobject.CreateReader(), instance);
            return instance;
        }
    }
}