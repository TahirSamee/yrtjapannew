using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;
using YRTJapan.DataAccess.Data;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.ROLE_ADMIN)]
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1️ DISPLAY ALL QUOTES
        public async Task<IActionResult> Index()
        {
            var viewModel = new DashboardViewModel
            {
                Quotes = await _context.FreeQuotes.ToListAsync(),
                Favourites = await _context.Favourites.ToListAsync(),
                Users = await _context.Users.ToListAsync()
            };
            return View(viewModel);
        }

    }
}
