using AtlanticCovidTracker.Client.Infrastructure;
using AtlanticCovidTracker.Client.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Client
{
    public class AtlanticCovidTrackerClient : IAtlanticCovidTrackerClient
    {

        private readonly ILogger<AtlanticCovidTrackerClient> _logger;
        private readonly HttpClient _httpClient;

        public AtlanticCovidTrackerClient(ILogger<AtlanticCovidTrackerClient> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<ApiStatus> GetApiStatus()
        {
            var response = await _httpClient.GetAsync("api/v1/status.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<ApiStatus>(_logger);
        }

        public async Task<IEnumerable<UnitedStatesData>> GetUnitedStatesHistoricData()
        {
            var response = await _httpClient.GetAsync("api/v1/us/daily.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<IEnumerable<UnitedStatesData>>(_logger);
        }

        public async Task<UnitedStatesData> GetUnitedStatesData(DateTime date)
        {
            var formattedDate = date.ToString("yyyyMMdd");
            // unlike the current endpoint, this returns one item
            var response = await _httpClient.GetAsync($"api/v1/us/{formattedDate}.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<UnitedStatesData>(_logger);
        }


        public async Task<UnitedStatesData> GetUnitedStatesCurrentData()
        {
            var response = await _httpClient.GetAsync("api/v1/us/current.json");
            response.CheckHttpResponse(_logger);
            // returns an array, assuming it will only have one item
            var result = await response.DeserializeAs<IEnumerable<UnitedStatesData>>(_logger);
            if (result.Count() != 1)
            {
                throw new AtlanticCovidTrackerClientException($"Expected one result, got '{result.Count()}'.");
            }
            return result.First();
        }

        public async Task<IEnumerable<StateMetadata>> GetStateMetadata()
        {
            var response = await _httpClient.GetAsync("api/v1/states/info.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<IEnumerable<StateMetadata>>(_logger);
        }

        public async Task<StateMetadata> GetStateMetadata(string state)
        {
            var response = await _httpClient.GetAsync($"api/v1/states/{state.ToLowerInvariant()}/info.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<StateMetadata>(_logger);
        }

        public async Task<IEnumerable<StateData>> GetStateHistoricData()
        {
            var response = await _httpClient.GetAsync("api/v1/states/daily.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<IEnumerable<StateData>>(_logger);
        }

        public async Task<IEnumerable<StateData>> GetStateHistoricData(string state)
        {
            var response = await _httpClient.GetAsync($"api/v1/states/{state.ToLowerInvariant()}/daily.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<IEnumerable<StateData>>(_logger);
        }

        public async Task<IEnumerable<StateData>> GetStateCurrentData()
        {
            var response = await _httpClient.GetAsync("api/v1/states/current.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<IEnumerable<StateData>>(_logger);
        }

        public async Task<StateData> GetStateCurrentData(string state)
        {
            var response = await _httpClient.GetAsync($"api/v1/states/{state.ToLowerInvariant()}/current.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<StateData>(_logger);
        }

        public async Task<StateData> GetStateData(string state, DateTime date)
        {
            var formattedDate = date.ToString("yyyyMMdd");
            var response = await _httpClient.GetAsync($"api/v1/states/{state.ToLowerInvariant()}/{formattedDate}.json");
            response.CheckHttpResponse(_logger);
            return await response.DeserializeAs<StateData>(_logger);
        }
    }
}
