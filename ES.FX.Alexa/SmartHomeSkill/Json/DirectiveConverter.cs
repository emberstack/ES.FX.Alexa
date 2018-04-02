using System;
using System.Linq;
using ES.FX.Alexa.SmartHomeSkill.Core;
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


            var directiveTypes =
                (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                    from type in assembly.GetTypes()
                    let attributes = type.GetCustomAttributes(typeof(DirectiveTypeAttribute), true)
                    where attributes != null && attributes.Length > 0
                    select new {Type = type, Attributes = attributes.Cast<DirectiveTypeAttribute>()}).ToList();

            var match = directiveTypes.Where(
                    s => s.Attributes.Any(a => a.Namespace == directiveNamespace && a.Name == directiveName)).Select(s=>s.Type)
                .FirstOrDefault();

            if (match == null) match = typeof(UnknownDirective);
            var directive = (Directive) Activator.CreateInstance(match);

            serializer.Populate(jobject.CreateReader(), directive);
            return directive;
        }
    }
}