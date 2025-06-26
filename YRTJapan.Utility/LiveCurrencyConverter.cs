using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YRTJapan.Utility
{
    public static class CurrencyConverterLive
    {
        // A single static HttpClient instance for the lifetime of the application.
        private static readonly HttpClient httpClient = new HttpClient();

        // Cached API data and the timestamp when it was last fetched.
        private static JObject cachedRates = null;
        private static DateTime cacheTimestamp = DateTime.MinValue;
        private static readonly TimeSpan CacheDuration = TimeSpan.FromHours(1);

        // The API endpoint with base JPY.
        private const string ApiUrl = "https://api.exchangerate-api.com/v4/latest/JPY";

        private static async Task<JObject> GetLatestRatesAsync()
        {
            try
            {
                if (cachedRates == null || (DateTime.UtcNow - cacheTimestamp) > CacheDuration)
                {
                    string json = await httpClient.GetStringAsync(ApiUrl);
                    cachedRates = JObject.Parse(json);
                    cacheTimestamp = DateTime.UtcNow;
                }
                return cachedRates;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving exchange rate data: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Converts an amount in Japanese Yen (JPY) to US Dollars (USD) using the API's USD rate.
        /// </summary>
        public static async Task<decimal> ConvertJPYToUSD(decimal jpyAmount)
        {
            try
            {
                var rates = await GetLatestRatesAsync();
                // USD per JPY conversion (e.g., 0.006756)
                decimal usdRate = (decimal)rates["rates"]["USD"];
                return jpyAmount * usdRate;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting JPY to USD: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Converts an amount in US Dollars (USD) to Japanese Yen (JPY) using the API's USD rate.
        /// </summary>
        public static async Task<decimal> ConvertUSDToJPY(decimal usdAmount)
        {
            try
            {
                var rates = await GetLatestRatesAsync();
                decimal usdRate = (decimal)rates["rates"]["USD"];
                return usdAmount / usdRate;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting USD to JPY: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Calculates the FOB price in Yen using the provided logic:
        /// </summary>
        public static decimal GetFOBPrice(decimal bidPriceInYen)
        {
            var additionPriceInYen = bidPriceInYen + 150000;
            var FOBPrice10Percent = additionPriceInYen * 0.10m;
            var FOBPrice = additionPriceInYen + FOBPrice10Percent;
            return FOBPrice;
        }

        public static decimal GetBidPriceFromFOBPrice(decimal fobPrice)
        {
            // Reverse the multiplication by (1.0m + 0.10m)
            decimal additionPriceInYen = fobPrice / (1.0m + 0.10m);
            // Reverse the initial addition of 125000
            decimal bidPriceInYen = additionPriceInYen - 150000m;
            return bidPriceInYen;
        }

        /// <summary>
        /// Converts the calculated FOB price (in Yen) to USD.
        /// This conversion divides the FOB price by the current "JPY per USD" rate.
        /// </summary>
        public static async Task<decimal> ConvertFobPriceToUSD(decimal bidPriceInYen)
        {
            try
            {
                // Calculate FOB price in Yen using the updated formula.
                decimal fobPriceInYen = GetFOBPrice(bidPriceInYen);

                // Get the current USD rate from the API (which is USD per JPY),
                // then calculate the inverse to obtain JPY per USD (e.g., 148.03).
                decimal jpyPerUsd = await GetJPYToUSDExchangeRateAsync();

                // Convert FOB price in Yen to USD.
                return fobPriceInYen / jpyPerUsd;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting FOB price to USD: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Converts a given USD amount (assumed to be the result of the FOB conversion)
        /// back into the original bid price in Yen.
        /// This inverts the conversion:
        /// bidPriceInYen = ((USD Amount * jpyPerUsd) - 125,000) / 1.1
        /// </summary>
        public static async Task<decimal> ConvertUSDToBidPriceInYen(decimal usdAmount)
        {
            try
            {
                // Get the current JPY per USD rate.
                decimal jpyPerUsd = await GetJPYToUSDExchangeRateAsync();

                // Convert the USD amount back to a FOB price in Yen.
                decimal fobPriceInYen = usdAmount * jpyPerUsd;

                // Invert the FOB formula.
                decimal bidPriceInYen = GetBidPriceFromFOBPrice(fobPriceInYen);

                if (bidPriceInYen < 0)
                {
                    return fobPriceInYen;
                }

                return bidPriceInYen;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting USD to bid price in Yen: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Retrieves the current JPY-to-USD exchange rate in terms of "JPY per USD".
        /// For example, if the API returns 0.006756 USD per JPY, this method returns approximately 148.03.
        /// </summary>
        public static async Task<decimal> GetJPYToUSDExchangeRateAsync()
        {
            try
            {
                // Refresh the cache if necessary.
                if (cachedRates == null || (DateTime.UtcNow - cacheTimestamp) > CacheDuration)
                {
                    string json = await httpClient.GetStringAsync(ApiUrl);
                    cachedRates = JObject.Parse(json);
                    cacheTimestamp = DateTime.UtcNow;
                }

                if (cachedRates["rates"]?["USD"] == null)
                    throw new Exception("USD rate not found in the API response.");

                // The API provides USD per JPY.
                decimal usdPerJpy = cachedRates["rates"]["USD"].Value<decimal>();
                // Convert to JPY per USD.
                decimal jpyPerUsd = 1 / usdPerJpy;
                return jpyPerUsd;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving JPY to USD exchange rate: " + ex.Message, ex);
            }
        }

        static string FormatNumber(decimal number)
        {
            string str = number.ToString("G", CultureInfo.InvariantCulture); // Convert to string without scientific notation
            int nonZeroCount = 0;
            int index = str.IndexOf('.') + 1;

            if (index == 0) return str; // No decimal point (integer case)

            for (int i = index; i < str.Length; i++)
            {
                if (str[i] != '0')
                    nonZeroCount++;

                if (nonZeroCount == 2) // Stop at 2 non-zero digits
                    return str.Substring(0, i + 1);
            }

            return str; // Return the original if it has fewer than 2 non-zero digits
        }

        /// <summary>
        /// Compares the given average and total price strings.
        /// If total is greater than avg, converts total to USD using the FOB conversion and returns the value.
        /// Otherwise returns 0.
        /// </summary>
        public static async Task<decimal> GetConvertedTotalPrice(string avgPrice, string totalPrice)
        {
            int avg = ExtractIntegerPart(avgPrice);
            int total = ExtractIntegerPart(totalPrice);

            if (total == 0 || avg > total)
                return 0;

            if (total > avg)
                return await ConvertFobPriceToUSD(total);

            return 0;
        }

        public static async Task<decimal> GetConvertedTotalBiggerPrice(string avgPrice, string totalPrice)
        {
            int avg = ExtractIntegerPart(avgPrice);
            int total = ExtractIntegerPart(totalPrice);

            // Get the bigger value between avg and total.
            int biggerValue = Math.Max(avg, total);

            // If the bigger value is 0, return 0.
            if (biggerValue == 0)
                return 0;

            // Convert the bigger value using ConvertFobPriceToUSD.
            return await ConvertFobPriceToUSD(biggerValue);
        }


        /// <summary>
        /// Extracts the integer part from a price string by removing currency symbols, commas, and non-numeric characters.
        /// </summary>
        private static int ExtractIntegerPart(string price)
        {
            if (string.IsNullOrWhiteSpace(price))
                return 0;

            string cleaned = Regex.Replace(price, @"[^\d\.\-]", "");
            if (decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal number))
            {
                return (int)Math.Truncate(number);
            }
            return 0;
        }
    }

}
