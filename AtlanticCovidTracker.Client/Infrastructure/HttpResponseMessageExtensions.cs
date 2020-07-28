using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Client.Infrastructure
{
    internal static class HttpResponseMessageExtensions
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static void CheckHttpResponse(this HttpResponseMessage response, ILogger logger)
        {
            var request = response.RequestMessage;
            if (response.IsSuccessStatusCode)
            {
                // TODO probably not necessary, the HttpClient logs
                //2020 - 07 - 28 14:59:34.1514 | INFO | System.Net.Http.HttpClient.IAtlanticCovidTrackerClient.ClientHandler | Sending HTTP request GET https://covidtracking.com/api/v1/us/current.json
                //2020 - 07 - 28 14:59:34.8817 | INFO | System.Net.Http.HttpClient.IAtlanticCovidTrackerClient.ClientHandler | Received HTTP response after 724.7737ms - OK
                //2020 - 07 - 28 14:59:34.8817 | INFO | System.Net.Http.HttpClient.IAtlanticCovidTrackerClient.LogicalHandler | End processing HTTP request after 744.4386ms - OK
                logger.LogInformation($"'{request.Method} {request.RequestUri}' returned success status code '{response.StatusCode}'.");
            }
            else
            {
                var message = $"'{request.Method} {request.RequestUri}' returned failure status code '{response.StatusCode}' and reason phrase '{response.ReasonPhrase}'.";
                logger.LogError(message);
                throw new AtlanticCovidTrackerClientException(message);
            }
        }

        public static async Task<T> DeserializeAs<T>(this HttpResponseMessage response, ILogger logger)
        {
            try
            {
                // using System.Text.Json instead of NewtonSoft
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    var content = await JsonSerializer.DeserializeAsync<T>(stream, _jsonSerializerOptions);
                    return content;
                }
            }
            catch (Exception ex)
            {
                var message = $"JSON deserialization to type '{typeof(T).FullName}' failed.";
                logger.LogError(message, ex);
                throw new AtlanticCovidTrackerClientException(message, ex);
            }
        }
    }
}
