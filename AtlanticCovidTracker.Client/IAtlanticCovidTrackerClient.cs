using AtlanticCovidTracker.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Client
{
    public interface IAtlanticCovidTrackerClient
    {
        Task<ApiStatus> GetApiStatus();
        Task<IEnumerable<UnitedStatesData>> GetUnitedStatesHistoricData();
        Task<UnitedStatesData> GetUnitedStatesCurrentData();
        Task<UnitedStatesData> GetUnitedStatesData(DateTime date);

        Task<IEnumerable<StateMetadata>> GetStateMetadata();
        Task<StateMetadata> GetStateMetadata(string state);

        Task<IEnumerable<StateData>> GetStateHistoricData();
        Task<IEnumerable<StateData>> GetStateHistoricData(string state);
        Task<IEnumerable<StateData>> GetStateCurrentData();
        Task<StateData> GetStateCurrentData(string state);
        Task<StateData> GetStateData(string state, DateTime date);
    }
}
