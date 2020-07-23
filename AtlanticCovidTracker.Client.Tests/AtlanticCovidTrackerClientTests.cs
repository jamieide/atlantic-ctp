using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Client.Tests
{
    [TestClass]
    public class AtlanticCovidTrackerClientTests
    {
        private static AtlanticCovidTrackerClient _atlanticCovidTrackerClient;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _atlanticCovidTrackerClient = Factory.GetAtlanticCovidTrackerClient();
        }

        [TestMethod]
        public async Task GetApiStatus()
        {
            var target = await _atlanticCovidTrackerClient.GetApiStatus();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public async Task GetUnitedStatesHistoricData_Succeeds()
        {
            var target = await _atlanticCovidTrackerClient.GetUnitedStatesHistoricData();
            Assert.IsNotNull(target);
            Assert.IsTrue(target.Any());
        }

        [TestMethod]
        public async Task GetUnitedStatesHistoricData_ForDate_Succeeds()
        {
            var date = DateTime.Today.AddDays(-1);
            var target = await _atlanticCovidTrackerClient.GetUnitedStatesHistoricData(date);
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public async Task GetUnitedStatesCurrentData_Succeeds()
        {
            var target = await _atlanticCovidTrackerClient.GetUnitedStatesCurrentData();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public async Task GetStateMetadata_Succeeds()
        {
            var target = await _atlanticCovidTrackerClient.GetStateMetadata();
            Assert.IsNotNull(target);
            Assert.IsTrue(target.Any());
        }

        [TestMethod]
        public async Task GetStateMetadata_ForState_Succeeds()
        {
            var target = await _atlanticCovidTrackerClient.GetStateMetadata("vt");
            Assert.IsNotNull(target);
        }
    }
}
