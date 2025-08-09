using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YRTJapan.Core.Entities;
using YRTJapan.DataAccess.Data;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.ROLE_ADMIN)]
    public class InquiryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InquiryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoadData()
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumnIndex = Request.Form["order[0][column]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int skip = start != null ? Convert.ToInt32(start) : 0;

            var quotesQuery = _context.FreeQuotes.AsQueryable();

            // 🏆 **Sorting Logic** 🏆
            var columnMapping = new Dictionary<int, string>
    {
        { 0, "Id" },
        { 1, "Name" },
        { 2, "Country" },
        { 3, "Email" },
        { 4, "PhoneNumber" },
        { 5, "Message" },
        { 6, "CarId" }
    };

            if (!string.IsNullOrEmpty(sortColumnIndex) && columnMapping.ContainsKey(Convert.ToInt32(sortColumnIndex)))
            {
                string columnName = columnMapping[Convert.ToInt32(sortColumnIndex)];
                if (sortColumnDirection == "asc")
                    quotesQuery = quotesQuery.OrderBy(e => EF.Property<object>(e, columnName));
                else
                    quotesQuery = quotesQuery.OrderByDescending(e => EF.Property<object>(e, columnName));
            }

            // 🏆 **Searching Logic** 🏆
            if (!string.IsNullOrEmpty(searchValue))
            {
                quotesQuery = quotesQuery.Where(q =>
                    q.Name.Contains(searchValue) ||
                    q.Country.Contains(searchValue) ||
                    q.Email.Contains(searchValue) ||
                    q.PhoneNumber.Contains(searchValue) ||
                    q.Message.Contains(searchValue) ||
                    q.CarId.ToString().Contains(searchValue));
            }

            int totalRecords = quotesQuery.Count();
            var data = quotesQuery.Skip(skip).Take(pageSize).ToList();

            return Json(new { draw = draw, recordsFiltered = totalRecords, recordsTotal = totalRecords, data = data });
        }


        [HttpPost]
        public async Task<IActionResult> AddFreeQuote([FromBody] FreeQuote quote)
        {
            if (quote.Name == null || quote.Country == null || quote.PhoneNumber == null || quote.Email == null)
            {
                return BadRequest(new { success = false, message = "Invalid data" });
            }

            _context.Add(quote);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Your quote request has been submitted successfully!" });
        }

        // 3️ EDIT (GET FORM)
        public async Task<IActionResult> EditByIdFreeQuote(int id)
        {
            var quote = await _context.FreeQuotes.FindAsync(id);
            if (quote == null) return NotFound();

            return View(quote);
        }

        // 4️⃣ UPDATE (POST REQUEST)
        [HttpPost]
        public async Task<IActionResult> EditFreeQuote(int id, [Bind("Id,Name,Country,Email,PhoneNumber,Message,CarId")] FreeQuote quote)
        {
            if (id != quote.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(quote);
                await _context.SaveChangesAsync();
                return Ok(new { success = true, message = "Quote Updated successfully!" });
            }
            return View(quote);
        }

        // 5️⃣ DELETE
        [HttpPost]
        public async Task<IActionResult> DeleteFreeQuote(int id)
        {
            var quote = await _context.FreeQuotes.FindAsync(id);
            if (quote == null) return NotFound();

            _context.FreeQuotes.Remove(quote);
            await _context.SaveChangesAsync();
            return Ok(new { success = true, message = "Quote deleted successfully!" });
        }
    }
}
