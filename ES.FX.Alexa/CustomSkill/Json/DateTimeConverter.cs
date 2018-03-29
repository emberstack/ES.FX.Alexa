using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ES.FX.Alexa.CustomSkill.Json
{
    public class DateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            switch (reader.Value)
            {
                case DateTime date: return date;
                case long longValue: return epoch.AddMilliseconds(longValue);
                case string stringValue: return DateTime.Parse(stringValue);
                default:
                    throw new NotSupportedException($"Could not convert value '{reader.Value}' to {typeof(DateTime)}");
            }
        }
    }
}