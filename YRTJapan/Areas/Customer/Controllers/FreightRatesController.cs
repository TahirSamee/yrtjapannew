using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class FreightRatesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActiveTab"] = "freightRates";
            return View();
        }
    }
}
