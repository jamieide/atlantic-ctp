using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client
{
    /// <summary>
    /// JsonConverter to convert Atlantic client date format (e.g. 20200722).
    /// </summary>
    internal class DateConverter: JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetInt32();
            return DateTime.ParseExact(value.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture.DateTimeFormat);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var dateString = value.ToString("yyyyMMdd");
            var dateInt = int.Parse(dateString);
            writer.WriteNumberValue(dateInt);
        }
    }
}
