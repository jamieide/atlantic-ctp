using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace AtlanticCovidTracker.Client.Tests
{
    [TestClass]
    public class Factory
    {
        private static AtlanticCovidTrackerClient _atlanticCovidTrackerClient;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            var logger = new NullLogger<AtlanticCovidTrackerClient>();
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://covidtracking.com/")
            };
            _atlanticCovidTrackerClient = new AtlanticCovidTrackerClient(logger, httpClient);
        }

        public static AtlanticCovidTrackerClient GetAtlanticCovidTrackerClient() => _atlanticCovidTrackerClient;
    }
}
