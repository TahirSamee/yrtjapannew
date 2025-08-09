using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using YRTJapan.Core.Entities;
using YRTJapan.UI.Services.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YRTJapan.UI.Services
{
    public class ApiService : IApiService
    {
        private readonly ApiSettings _apiSettings;
        private readonly ILogger<ApiService> _logger;

        public ApiService(IConfiguration configuration, ILogger<ApiService> logger)
        {
            _apiSettings = configuration.GetSection("ApiSettings").Get<ApiSettings>();
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ApiResponse<dynamic>> AjGetAsync(string sql)
        {
            try
            {
                string url = $"{GetBaseURL()}&sql={Uri.EscapeDataString(sql)}";

                // Log the request URL for debugging
                _logger.LogInformation("Request URL: {Url}", url);

                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(url);

                    // Log response if needed (truncated for length)
                    _logger.LogDebug("Response received: {ResponseSnippet}...", response.Length > 100 ? response.Substring(0, 100) : response);

                    // Check if the response needs GZIP decompression
                    if (_apiSettings.Go == "gzip")
                    {
                        response = DecompressGzip(response);
                    }

                    // Deserialize and return the response
                    var data = JsonConvert.DeserializeObject<dynamic>(response);
                    return new ApiResponse<dynamic> { IsSuccess = true, Message = "Data fetched successfully.", Data = data, StatusCode = 400 };

                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "HTTP request error occurred while accessing URL.");
                return new ApiResponse<dynamic> { IsSuccess = false, Message = $"HTTP request error occurred while accessing the API:: { ex.Message}", StatusCode = 500 };
            }
            catch (IOException ex)
            {
                _logger.LogError(ex, "IO error occurred while handling the response.");
                return new ApiResponse<dynamic> { IsSuccess = false, Message = $"An I/O error occurred while handling the response:: {ex.Message}", StatusCode = 500 };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred.");
                return new ApiResponse<dynamic> { IsSuccess = false, Message = $"An unexpected error occurred. Please check the logs for more details:: {ex.Message}", StatusCode = 500 };
            }
        }
        public async Task<ApiResponse<dynamic>> RunMultipleQueriesAsync(List<string> sqlQueries)
        {
            try
            {
                string baseUrl = GetBaseURL();

                // Log the base URL for debugging
                _logger.LogInformation("Base URL: {BaseUrl}", baseUrl);

                using (HttpClient client = new HttpClient())
                {
                    var allResults = new List<dynamic>();

                    foreach (var sql in sqlQueries)
                    {
                        string url = $"{baseUrl}&sql={Uri.EscapeDataString(sql)}";
                        string response = await client.GetStringAsync(url);

                        // Log response if needed (truncated for length)
                        _logger.LogDebug("Response received: {ResponseSnippet}...", response.Length > 100 ? response.Substring(0, 100) : response);

                        // Check if the response needs GZIP decompression
                        if (_apiSettings.Go == "gzip")
                        {
                            response = DecompressGzip(response);
                        }

                        // Deserialize and add the response to the results list
                        var data = JsonConvert.DeserializeObject<dynamic>(response);
                        allResults.Add(data);
                    }

                    return new ApiResponse<dynamic> { IsSuccess = true, Message = "All data fetched successfully.", Data = allResults, StatusCode = 200 };
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "HTTP request error occurred while accessing URL.");
                return new ApiResponse<dynamic> { IsSuccess = false, Message = $"HTTP request error occurred while accessing the API:: {ex.Message}", StatusCode = 500 };
            }
            catch (IOException ex)
            {
                _logger.LogError(ex, "IO error occurred while handling the response.");
                return new ApiResponse<dynamic> { IsSuccess = false, Message = $"An I/O error occurred while handling the response:: {ex.Message}", StatusCode = 500 };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred.");
                return new ApiResponse<dynamic> { IsSuccess = false, Message = $"An unexpected error occurred. Please check the logs for more details:: {ex.Message}", StatusCode = 500 };
            }
        }

        private string GetClientIp()
        {
            return "127.0.0.1";
        }
        private string GetBaseURL()
        {
            return $"http://{_apiSettings.Server}/{_apiSettings.Go}/?json&code={_apiSettings.Code}";
        }

        private string DecompressGzip(string compressedData)
        {
            try
            {
                byte[] compressedBytes = Convert.FromBase64String(compressedData);
                using (var compressedStream = new MemoryStream(compressedBytes))
                using (var decompressionStream = new System.IO.Compression.GZipStream(compressedStream, System.IO.Compression.CompressionMode.Decompress))
                using (var resultStream = new MemoryStream())
                {
                    decompressionStream.CopyTo(resultStream);
                    return System.Text.Encoding.UTF8.GetString(resultStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during GZIP decompression.");
                throw new Exception("An error occurred while decompressing data.");
            }
        }
    }
}
