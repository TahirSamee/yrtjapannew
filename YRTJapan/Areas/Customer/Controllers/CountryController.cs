using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CountryController : Controller
    {
        public IActionResult Zambia()
        {
            return View();
        }
        public IActionResult Tanzania()
        {
            return View();
        } 
        public IActionResult Kenya()
        {
            return View();
        }
        public IActionResult DRCongo()
        {
            return View();
        }
    }
}
