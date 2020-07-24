using AtlanticCovidTracker.Client.Infrastructure;
using System;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client.Models
{
    public class ApiStatus
    {
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime BuildTime { get; set; }
        public bool Production { get; set; }
        public string RunNumber { get; set; }
    }
}
