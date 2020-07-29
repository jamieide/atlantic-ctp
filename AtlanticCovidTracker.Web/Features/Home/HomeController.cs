using AtlanticCovidTracker.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Web.Features.Home
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAtlanticCovidTrackerClient _atlanticCovidTrackerClient;

        public HomeController(ILogger<HomeController> logger, IAtlanticCovidTrackerClient atlanticCovidTrackerClient)
        {
            _logger = logger;
            _atlanticCovidTrackerClient = atlanticCovidTrackerClient;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _atlanticCovidTrackerClient.GetApiStatus();
            return View(vm);
        }
    }
}
