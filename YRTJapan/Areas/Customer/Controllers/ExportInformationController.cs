using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ExportInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
