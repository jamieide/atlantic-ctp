using AtlanticCovidTracker.Client.Models;

namespace AtlanticCovidTracker.Web.Features.States
{
    public class CurrentForStateViewModel
    {
        public StateData CurrentData { get; set; }
        public StateMetadata StateMetadata { get; set; }
    }
}
