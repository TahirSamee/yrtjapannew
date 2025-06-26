using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CarInquiryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActiveTab"] = "carInquiry";
            return View();
        }
    }
}
