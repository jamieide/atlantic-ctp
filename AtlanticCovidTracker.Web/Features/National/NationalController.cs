using System.Threading.Tasks;
using AtlanticCovidTracker.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AtlanticCovidTracker.Web.Features.National
{
    public class NationalController : Controller
    {
        private readonly ILogger<NationalController> _logger;
        private readonly IAtlanticCovidTrackerClient _atlanticCovidTrackerClient;

        public NationalController(ILogger<NationalController> logger, IAtlanticCovidTrackerClient atlanticCovidTrackerClient)
        {
            _logger = logger;
            _atlanticCovidTrackerClient = atlanticCovidTrackerClient;
        }

        public async Task<IActionResult> Current()
        {
            var vm = await _atlanticCovidTrackerClient.GetUnitedStatesCurrentData();
            return View(vm);
        }

        public async Task<IActionResult> Historic()
        {
            var vm = await _atlanticCovidTrackerClient.GetUnitedStatesHistoricData();
            return View(vm);
        }
    }
}
