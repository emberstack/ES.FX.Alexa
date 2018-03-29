using System;
using System.Linq;
using ES.FX.Alexa.CustomSkill.Core;
using ES.FX.Alexa.CustomSkill.Core.Requests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Alexa.CustomSkill.Json
{
    public class SkillRequestConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Request);
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

            var possibleTypes =
                (from type in typeof(SkillRequestTypeAttribute).Assembly.GetTypes()
                    let attributes = type.GetCustomAttributes(typeof(SkillRequestTypeAttribute), true)
                    where attributes != null && attributes.Length > 0
                    select new {Type = type, Attributes = attributes.Cast<SkillRequestTypeAttribute>()}).ToList();

            var match = possibleTypes.Where(s => s.Attributes.Any(a => a.Type == requestType))
                .Select(s => s.Type).FirstOrDefault();
            if (match == null) match = typeof(UnknownRequest);
            var instance = Activator.CreateInstance(match);
            serializer.Populate(jobject.CreateReader(), instance);
            return instance;
        }
    }
}