using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class BankInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
