using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
