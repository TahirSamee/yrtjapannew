using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using YRTJapan.Areas.Customer.Controllers;
using YRTJapan.Core.Entities;
using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.UI.Services.Interfaces;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class GeneralInquiriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GeneralInquiriesController( ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> FreeQuote1([FromBody] GeneralInquiry generalInquiry)
        //{
        //    if (generalInquiry.FirstName == null || generalInquiry.LastName == null || generalInquiry.Country == null || generalInquiry.PhoneNumber == null || generalInquiry.Email == null)
        //    {
        //        return BadRequest(new { success = false, message = "Invalid data" });
        //    }

        //    _context.Add(generalInquiry);
        //    await _context.SaveChangesAsync();

        //    return Ok(new { success = true, message = "Your quote request has been submitted successfully!" });
        //}
        [HttpPost]
        public async Task<IActionResult> FreeQuote1([FromBody] GeneralInquiry generalInquiry)
        {
            if (generalInquiry == null)
            {
                return BadRequest(new { success = false, message = "Invalid request" });
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(generalInquiry.FirstName) ||
                string.IsNullOrWhiteSpace(generalInquiry.LastName) ||
                string.IsNullOrWhiteSpace(generalInquiry.Country) ||
                string.IsNullOrWhiteSpace(generalInquiry.PhoneNumber) ||
                string.IsNullOrWhiteSpace(generalInquiry.Email))
            {
                return BadRequest(new { success = false, message = "All fields are required." });
            }

            try
            {
                _context.GeneralInquiries.Add(generalInquiry); // Ensure GeneralInquiries DbSet is used
                await _context.SaveChangesAsync();

                return Ok(new { success = true, message = "Your quote request has been submitted successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "An error occurred while processing your request.", error = ex.Message });
            }
        }

    }
}