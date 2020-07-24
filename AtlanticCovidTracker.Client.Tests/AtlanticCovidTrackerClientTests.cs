using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;
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
            var target = await _atlanticCovidTrackerClient.GetUnitedStatesData(date);
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
        [DataRow("vt")]
        [DataRow("VT")]
        public async Task GetStateMetadata_ForState_Succeeds(string state)
        {
            var target = await _atlanticCovidTrackerClient.GetStateMetadata(state);
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public async Task GetStateHistoricData_Succeeds()
        {
            var target = await _atlanticCovidTrackerClient.GetStateHistoricData();
            Assert.IsNotNull(target);
            Assert.IsTrue(target.Any());
            var missingDate = target.Where(x => x.LastUpdateEt == DateTime.MinValue).ToList();
            if (missingDate.Any())
            {
                var x = 1;
            }
        }

        [TestMethod]
        [DataRow("vt")]
        [DataRow("VT")]
        public async Task GetStateHistoricData_ForState_Succeeds(string state)
        {
            var target = await _atlanticCovidTrackerClient.GetStateHistoricData(state);
            Assert.IsNotNull(target);
            Assert.IsTrue(target.Any());
        }

        [TestMethod]
        public async Task GetStateCurrentData_Succeeds()
        {
            var target = await _atlanticCovidTrackerClient.GetStateCurrentData();
            Assert.IsNotNull(target);
            Assert.IsTrue(target.Any());
        }

        [TestMethod]
        [DataRow("vt")]
        [DataRow("VT")]
        public async Task GetStateCurrentData_ForState_Succeeds(string state)
        {
            var target = await _atlanticCovidTrackerClient.GetStateCurrentData(state);
            Assert.IsNotNull(target);
        }

        [TestMethod]
        [DataRow("vt")]
        [DataRow("VT")]
        public async Task GetStateData_Succeeds(string state)
        {
            var date = DateTime.Today.AddDays(-2);
            var target = await _atlanticCovidTrackerClient.GetStateData(state, date);
            Assert.IsNotNull(target);
        }
    }
}
