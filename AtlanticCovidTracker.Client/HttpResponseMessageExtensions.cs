using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AtlanticCovidTracker.Client
{
    internal static class HttpResponseMessageExtensions
    {
        private static JsonSerializerOptions _jsonSerializerOptions;

        static HttpResponseMessageExtensions()
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            _jsonSerializerOptions.Converters.Add(new DateConverter());
        }

        public static void CheckHttpResponse(this HttpResponseMessage response, ILogger logger)
        {
            var request = response.RequestMessage;
            if (response.IsSuccessStatusCode)
            {
                logger.LogTrace($"'{request.Method} {request.RequestUri}' returned success status code '{response.StatusCode}'.");
            }
            else
            {
                var message = $"'{request.Method} {request.RequestUri}' returned failure status code '{response.StatusCode}' and reason phrase '{response.ReasonPhrase}'.";
                logger.LogCritical(message);
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
                logger.LogCritical(message, ex);
                throw new AtlanticCovidTrackerClientException(message, ex);
            }
        }
    }
}
