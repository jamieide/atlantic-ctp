using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Client
{
    public interface IAtlanticCovidTrackerClient
    {
        Task<ApiStatus> GetApiStatus();
        Task<IEnumerable<UnitedStatesData>> GetUnitedStatesHistoricData();
        Task<UnitedStatesData> GetUnitedStatesHistoricData(DateTime date);
        Task<UnitedStatesData> GetUnitedStatesCurrentData();
        Task<IEnumerable<StateMetadata>> GetStateMetadata();
        Task<StateMetadata> GetStateMetadata(string state);
    }
}
