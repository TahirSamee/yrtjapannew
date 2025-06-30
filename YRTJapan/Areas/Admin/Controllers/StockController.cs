using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.ROLE_ADMIN)]
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
