using AtlanticCovidTracker.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Web.Features.States
{
    public class HistoricForStateViewModel
    {
        public IEnumerable<StateData> HistoricData { get; set; }
        public StateMetadata StateMetadata { get; set; }
    }
}
