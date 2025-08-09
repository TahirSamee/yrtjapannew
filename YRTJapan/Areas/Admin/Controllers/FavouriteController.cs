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
    public class FavouriteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FavouriteController(ApplicationDbContext context)
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

            var favouritesQuery = _context.Favourites.Select(f => new
            {
                f.Id,
                f.MakeName,
                f.ModelName,
                f.Year,
                f.UserId,
                f.Price
            });

            // 🏆 **Sorting Logic** 🏆
            var columnMapping = new Dictionary<int, string>
    {
        { 0, "Id" },
        { 1, "MakeName" },
        { 2, "ModelName" },
        { 3, "Year" },
        { 4, "UserId" },
        { 5, "Price" }
    };

            if (!string.IsNullOrEmpty(sortColumnIndex) && columnMapping.ContainsKey(Convert.ToInt32(sortColumnIndex)))
            {
                string columnName = columnMapping[Convert.ToInt32(sortColumnIndex)];
                if (sortColumnDirection == "asc")
                    favouritesQuery = favouritesQuery.OrderBy(e => EF.Property<object>(e, columnName));
                else
                    favouritesQuery = favouritesQuery.OrderByDescending(e => EF.Property<object>(e, columnName));
            }

            // 🏆 **Searching Logic** 🏆
            if (!string.IsNullOrEmpty(searchValue))
            {
                favouritesQuery = favouritesQuery.Where(f =>
                    f.MakeName.Contains(searchValue) ||
                    f.ModelName.Contains(searchValue) ||
                    f.Year.ToString().Contains(searchValue) ||
                    f.UserId.ToString().Contains(searchValue) ||
                    f.Price.ToString().Contains(searchValue));
            }

            int totalRecords = favouritesQuery.Count();
            var data = favouritesQuery.Skip(skip).Take(pageSize).ToList();

            return Json(new { draw = draw, recordsFiltered = totalRecords, recordsTotal = totalRecords, data = data });
        }


        [HttpPost]
        public async Task<IActionResult> AddFavourite([FromBody] Favourite favourite)
        {
            if (favourite.MakeName == null || favourite.ModelName == null || favourite.Year == 0 || favourite.UserId == null || favourite.Price == 0)
            {
                return BadRequest(new { success = false, message = "Invalid data" });
            }

            _context.Add(favourite);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Your favourite request has been submitted successfully!" });
        }

        // 3️ EDIT (GET FORM)
        public async Task<IActionResult> EditByIdFavourite(int id)
        {
            var favourite = await _context.Favourites.FindAsync(id);
            if (favourite == null) return NotFound();

            return View(favourite);
        }

        // 4️⃣ UPDATE (POST REQUEST)
        [HttpPost]
        public async Task<IActionResult> EditFavourite(int id, [Bind("Id,MakeName,ModelName,Year,UserId,Price")] Favourite favourite)
        {
            if (id != favourite.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(favourite);
                await _context.SaveChangesAsync();
                return Ok(new { success = true, message = "Favourite Updated successfully!" });
            }
            return BadRequest(new { success = false, message = "Favourite not updated successfully!" });
        }

        // 5️⃣ DELETE
        [HttpPost]
        public async Task<IActionResult> DeleteFavourite(int id)
        {
            var favourite = await _context.Favourites.FindAsync(id);
            if (favourite == null) return NotFound();

            _context.Favourites.Remove(favourite);
            await _context.SaveChangesAsync();
            return Ok(new { success = true, message = "Favourite deleted successfully!" });
        }
    }
}

