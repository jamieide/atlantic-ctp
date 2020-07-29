using AtlanticCovidTracker.Client.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client.Models
{
    public class ApiStatus
    {
        [JsonConverter(typeof(DateTimeConverter))]
        [Display(Name = "Build Time", Description = "The last time the API was built.")]
        public DateTime BuildTime { get; set; }
        [Display(Name = "Production", Description = "Whether this is a production build of the API.")]
        public bool Production { get; set; }
        [Display(Name = "Run Number", Description = "The run ID. Set to zero if it is a non-production run.")]
        public string RunNumber { get; set; }
    }
}
