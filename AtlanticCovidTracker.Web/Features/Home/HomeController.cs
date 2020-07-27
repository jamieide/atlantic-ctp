using Microsoft.AspNetCore.Mvc;

namespace AtlanticCovidTracker.Web.Features.Home
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
