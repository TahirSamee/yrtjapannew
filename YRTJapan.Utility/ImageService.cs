using Microsoft.Extensions.Caching.Memory;
using System.Drawing;

namespace YRTJapan.Utility
{
    public class ImageService : IImageService
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _cache;

        public ImageService(IHttpClientFactory httpClientFactory, IMemoryCache cache)
        {
            _httpClient = httpClientFactory.CreateClient(); // HttpClient via DI factory
            _cache = cache;
        }

        // Checks if an image URL is available (with caching)
        public async Task<bool> IsImageAvailableNoAvgSatAsync(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
                return false;

            // Check cache first to avoid duplicate HTTP calls
            if (_cache.TryGetValue(imageUrl, out bool exists))
            {
                return exists;
            }

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Head, imageUrl);
                using HttpResponseMessage response = await _httpClient.SendAsync(request);

                // If not successful, the image is not available.
                if (!response.IsSuccessStatusCode)
                {
                    exists = false;
                }
                else if (response.Content.Headers.ContentType != null)
                {
                    // Only consider it available if the content type starts with "image/"
                    exists = response.Content.Headers.ContentType.MediaType.StartsWith("image/");
                }
                else
                {
                    exists = false;
                }
            }
            catch
            {
                exists = false;
            }

            // Store result in cache for future calls (e.g. 30 minutes)
            _cache.Set(imageUrl, exists, TimeSpan.FromDays(1));
            return exists;
        }

        public async Task<bool> IsImageAvailableAsync(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl)) return false;

            // Check cache first to avoid duplicate HTTP calls
            if (_cache.TryGetValue(imageUrl, out bool exists))
            {
                return exists;
            }

            try
            {
                // 1. Check if URL returns a valid image
                var request = new HttpRequestMessage(HttpMethod.Head, imageUrl);
                using HttpResponseMessage response = await _httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    exists = false;
                }
                else
                {
                    // 2. Download a portion of the image to analyze color
                    byte[] imgData = await _httpClient.GetByteArrayAsync(imageUrl);
                    using var ms = new MemoryStream(imgData);
                    // 3. Attempt to load it as a Bitmap (throws if invalid format)
                    using var bmp = new Bitmap(ms);
                    // 4. Compute average saturation
                    var avgSaturation = GetAverageSaturation(bmp);

                    // If below threshold, assume it's a black-and-white "auction sheet"
                    exists = avgSaturation > 0.05; // Adjust threshold as needed
                }
            }
            catch
            {
                exists = false;
            }

            // Cache result for future calls
            _cache.Set(imageUrl, exists, TimeSpan.FromMinutes(30));
            return exists;
        }

        /// <summary>
        /// Computes the average saturation of the given bitmap. 
        /// A low average saturation suggests the image is mostly grayscale or line art.
        /// </summary>
        private float GetAverageSaturation(Bitmap bmp)
        {
            float totalSaturation = 0;
            int sampleCount = 0;

            // Sample a subset of pixels (e.g. a 10x10 grid) for performance
            int stepX = Math.Max(1, bmp.Width / 10);
            int stepY = Math.Max(1, bmp.Height / 10);

            for (int y = 0; y < bmp.Height; y += stepY)
            {
                for (int x = 0; x < bmp.Width; x += stepX)
                {
                    Color c = bmp.GetPixel(x, y);
                    // Convert to HSL or HSV. Simple approach: use max-min for saturation
                    float max = Math.Max(c.R, Math.Max(c.G, c.B)) / 255f;
                    float min = Math.Min(c.R, Math.Min(c.G, c.B)) / 255f;
                    float saturation = (max == 0) ? 0 : (max - min) / max;

                    totalSaturation += saturation;
                    sampleCount++;
                }
            }

            return (sampleCount == 0) ? 0 : (totalSaturation / sampleCount);
        }

        public async Task<List<string>> FilterValidImageUrlsWithDetectingImagesAsync(IEnumerable<string> imageUrls)
        {
            var urlList = imageUrls.ToList();
            // Start all checks concurrently
            var checkTasks = urlList.Select(url => IsImageAvailableNoAvgSatAsync(url)).ToList();
            bool[] results = await Task.WhenAll(checkTasks);

            // Collect URLs that are valid (exists = true)
            var validUrls = new List<string>();
            for (int i = 0; i < urlList.Count; i++)
            {
                if (results[i])
                    validUrls.Add(urlList[i]);
            }

            // Remove the specific unwanted URL if it exists
            var unwantedUrl = "https://8.ajes.com/imgs/23FClskybXGhLPfATtD7CP5FcOsJiU5rtUrjkY0TqW";
            validUrls.RemoveAll(url => string.Equals(url, unwantedUrl, StringComparison.OrdinalIgnoreCase));

            return validUrls;
        }

        public List<string> FilterValidImageUrlsAsync(IEnumerable<string> imageUrls)
        {
            var validUrls = imageUrls.ToList();
            var unwantedUrl = "https://8.ajes.com/imgs/23FClskybXGhLPfATtD7CP5FcOsJiU5rtUrjkY0TqW";
            validUrls.RemoveAll(url => string.Equals(url, unwantedUrl, StringComparison.OrdinalIgnoreCase));

            return validUrls;
        }


        public async Task<List<string>> FilterValidImageUrlsRemoveLastAsync(IEnumerable<string> imageUrls)
        {
            var urlList = imageUrls.ToList();

            // If more than 5 images, remove the last one
            if (urlList.Count > 5)
            {
                urlList.RemoveAt(urlList.Count - 1);
            }

            // Start all checks concurrently
            var checkTasks = urlList.Select(url => IsImageAvailableNoAvgSatAsync(url)).ToList();
            bool[] results = await Task.WhenAll(checkTasks);

            // Collect URLs that are valid (exists = true)
            var validUrls = new List<string>();
            for (int i = 0; i < urlList.Count; i++)
            {
                if (results[i])
                    validUrls.Add(urlList[i]);
            }
            return validUrls;
        }

    }

    public interface IImageService
    {
        Task<bool> IsImageAvailableAsync(string imageUrl);
        Task<List<string>> FilterValidImageUrlsWithDetectingImagesAsync(IEnumerable<string> imageUrls);
        List<string> FilterValidImageUrlsAsync(IEnumerable<string> imageUrls);
    }
}
