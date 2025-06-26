using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CurrencyController : Controller
    {
        // GET: /Customer/Currency/Convert?price=3415&targetCurrency=JPY
        [HttpGet]
        public async Task<IActionResult> Convert(decimal price, string targetCurrency)
        {
            decimal convertedPrice = price;
            try
            {
                if (targetCurrency == "JPY")
                {
                    convertedPrice = await CurrencyConverterLive.ConvertUSDToJPY(price);
                }
                else if (targetCurrency == "USD")
                {
                    convertedPrice = await CurrencyConverterLive.ConvertJPYToUSD(price);
                }
                string currencySymbol = targetCurrency == "JPY" ? "¥" : "$";
                return Json(new { convertedPrice = currencySymbol + convertedPrice.ToString("N0") });
            }
            catch (System.Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

    }
}
