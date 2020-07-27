using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtlanticCovidTracker.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AtlanticCovidTracker.Web.Controllers
{
    public class UnitedStatesController : Controller
    {
        private readonly ILogger<UnitedStatesController> _logger;
        private readonly IAtlanticCovidTrackerClient _atlanticCovidTrackerClient;

        public UnitedStatesController(ILogger<UnitedStatesController> logger, IAtlanticCovidTrackerClient atlanticCovidTrackerClient)
        {
            _logger = logger;
            _atlanticCovidTrackerClient = atlanticCovidTrackerClient;
        }

        [HttpGet]
        public async Task<IActionResult> Current()
        {
            var model = await _atlanticCovidTrackerClient.GetUnitedStatesCurrentData();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Historic()
        {
            var model = await _atlanticCovidTrackerClient.GetUnitedStatesHistoricData();
            return View(model);
        }
    }
}
