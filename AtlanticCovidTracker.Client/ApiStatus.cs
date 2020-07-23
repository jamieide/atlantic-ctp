using System;

namespace AtlanticCovidTracker.Client
{
    // TODO BuildTime is a date, RunNumber is a string
    public class ApiStatus
    {
        public string BuildTime { get; set; }
        public bool Production { get; set; }
        public string RunNumber { get; set; }
    }
}
