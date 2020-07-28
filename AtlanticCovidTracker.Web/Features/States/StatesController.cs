using System.Threading.Tasks;
using AtlanticCovidTracker.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AtlanticCovidTracker.Web.Features.States
{
    public class StatesController : Controller
    {
        private readonly ILogger<StatesController> _logger;
        private readonly IAtlanticCovidTrackerClient _atlanticCovidTrackerClient;

        public StatesController(ILogger<StatesController> logger, IAtlanticCovidTrackerClient atlanticCovidTrackerClient)
        {
            _logger = logger;
            _atlanticCovidTrackerClient = atlanticCovidTrackerClient;
        }

        public async Task<IActionResult> Current()
        {
            var vm = await _atlanticCovidTrackerClient.GetStateCurrentData();
            return View(vm);
        }

        public async Task<IActionResult> CurrentForState(string id)
        {
            // kind of silly to parallel these
            var getStateCurrentDataTask = _atlanticCovidTrackerClient.GetStateCurrentData(id);
            var getStateMetadata = _atlanticCovidTrackerClient.GetStateMetadata(id);
            var stateCurrentData = await getStateCurrentDataTask;
            var stateMetadata = await getStateMetadata;
            var vm = new CurrentForStateViewModel
            {
                CurrentData = stateCurrentData,
                StateMetadata = stateMetadata
            };
            
            return View(vm);
        }

        public async Task<IActionResult> HistoricForState(string id)
        {
            // kind of silly to parallel these
            var getStateHistoricDataTask = _atlanticCovidTrackerClient.GetStateHistoricData(id);
            var getStateMetadata = _atlanticCovidTrackerClient.GetStateMetadata(id);
            var stateHistoricData = await getStateHistoricDataTask;
            var stateMetadata = await getStateMetadata;
            var vm = new HistoricForStateViewModel
            {
                HistoricData = stateHistoricData,
                StateMetadata = stateMetadata
            };

            return View(vm);
        }
    }
}
