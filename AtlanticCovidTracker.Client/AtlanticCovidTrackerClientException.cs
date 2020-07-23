using System;

namespace AtlanticCovidTracker.Client
{
    public class AtlanticCovidTrackerClientException : Exception
    {
        public AtlanticCovidTrackerClientException(string message) : base(message) { }
        public AtlanticCovidTrackerClientException(string message, Exception ex) : base(message, ex) { }
    }
}
