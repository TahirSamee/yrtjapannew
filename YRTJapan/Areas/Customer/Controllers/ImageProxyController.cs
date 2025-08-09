//using Microsoft.AspNetCore.Mvc;

//namespace YRTJapan.UI.Areas.Customer.Controllers
//{
//    [Area("Customer")]
//    //[Route("Customer/[controller]/[action]")]
//    public class ImageProxyController : Controller
//    {
//        private readonly HttpClient _httpClient;

//        public ImageProxyController(IHttpClientFactory httpClientFactory)
//        {
//            _httpClient = httpClientFactory.CreateClient();
//        }

//        [HttpGet]
//        public async Task<IActionResult> Proxy(string url)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                return BadRequest("Missing url parameter");
//            }

//            try
//            {
//                // Fetch the image from the remote URL.
//                var response = await _httpClient.GetAsync(url);
//                if (!response.IsSuccessStatusCode)
//                {
//                    return StatusCode((int)response.StatusCode, "Error fetching image");
//                }

//                // Get the content type (if not available, use a default)
//                var contentType = response.Content.Headers.ContentType?.ToString() ?? "application/octet-stream";
//                var imageBytes = await response.Content.ReadAsByteArrayAsync();

//                // Add CORS header so the image can be used on your domain.
//                Response.Headers.Add("Access-Control-Allow-Origin", "*");
//                return File(imageBytes, contentType);
//            }
//            catch (System.Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }
//    }
//}

using System;
using System.Net.Http;
using System.Security.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ImageProxyController : Controller
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly ILogger<ImageProxyController> _logger;

        public ImageProxyController(IHostEnvironment env, IConfiguration config, ILogger<ImageProxyController> logger)
        {
            _env = env;
            _config = config;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Proxy(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return BadRequest("Image URL is required.");
            }

            // Determine if we should disable SSL certificate validation (for development debugging only)
            //bool disableSslValidation = _config.GetValue<bool>("DisableSSLValidation");
            bool disableSslValidation = false;
            bool skipCertValidation = disableSslValidation && _env.IsDevelopment();

            HttpResponseMessage response;
            try
            {
                if (skipCertValidation)
                {
                    // **Development Mode**: Allow untrusted SSL certificates for debugging
                    var handler = new HttpClientHandler
                    {
                        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                    };
                    _logger.LogWarning("SSL validation is DISABLED for this request (Development mode). Proceeding without certificate checks.");
                    using (var httpClient = new HttpClient(handler))
                    {
                        response = await httpClient.GetAsync(url);
                    }
                }
                else
                {
                    // **Production/Default**: Use default SSL validation
                    using (var httpClient = new HttpClient())
                    {
                        response = await httpClient.GetAsync(url);
                    }
                }
            }
            catch (HttpRequestException ex) when (ex.InnerException is AuthenticationException authEx)
            {
                // Handle SSL certificate errors specifically
                _logger.LogError(ex, "SSL certificate error when fetching image from {URL}: {Message}", url, authEx.Message);
                if (skipCertValidation)
                {
                    // In dev/debug mode, provide detailed error info
                    return StatusCode(502, $"SSL validation failed: {authEx.Message}");
                }
                // In production, don't expose internals – just indicate a bad gateway or error
                return StatusCode(502, "Failed to retrieve the image due to an SSL certificate error.");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                _logger.LogError(ex, "Unexpected error fetching image from {URL}: {Message}", url, ex.Message);
                if (_env.IsDevelopment())
                {
                    // Return detailed error in Development for troubleshooting
                    return StatusCode(500, $"Error retrieving image: {ex.Message}");
                }
                return StatusCode(500, "Internal error retrieving the image.");
            }

            if (!response.IsSuccessStatusCode)
            {
                // The remote server returned an HTTP error (e.g., 404 or 500)
                _logger.LogWarning("Non-success status code {StatusCode} fetching image from {URL}", (int)response.StatusCode, url);
                return StatusCode((int)response.StatusCode, "Failed to retrieve the image from the remote server.");
            }

            // Success: read the image content and return it with the correct content type
            byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();
            string contentType = response.Content.Headers.ContentType?.ToString() ?? "application/octet-stream";
            return File(imageBytes, contentType);
        }
    }
}
