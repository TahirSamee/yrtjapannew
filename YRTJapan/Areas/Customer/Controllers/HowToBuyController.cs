using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HowToBuyController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActiveTab"] = "howToBuy";
            return View();
        }
    }
}
