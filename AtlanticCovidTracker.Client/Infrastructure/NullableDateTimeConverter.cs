﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client.Infrastructure
{
    internal class NullableDateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (string.IsNullOrEmpty(s))
            {
                return default;
            }
            return DateTime.Parse(s);
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
