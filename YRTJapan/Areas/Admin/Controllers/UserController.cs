using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YRTJapan.Core;
using YRTJapan.DataAccess.Data;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.ROLE_ADMIN)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
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

            var usersQuery = _context.Users.AsQueryable();

   
            var columnMapping = new Dictionary<int, string>
             {
                    { 0, "Id" },
                    { 1, "UserName" },
                    { 2, "Email" }
                };

            if (!string.IsNullOrEmpty(sortColumnIndex) && columnMapping.ContainsKey(Convert.ToInt32(sortColumnIndex)))
            {
                string columnName = columnMapping[Convert.ToInt32(sortColumnIndex)];
                if (sortColumnDirection == "asc")
                    usersQuery = usersQuery.OrderBy(e => EF.Property<object>(e, columnName));
                else
                    usersQuery = usersQuery.OrderByDescending(e => EF.Property<object>(e, columnName));
            }

            if (!string.IsNullOrEmpty(searchValue))
            {
                usersQuery = usersQuery.Where(u =>
                    u.UserName.Contains(searchValue) ||
                    u.Email.Contains(searchValue));
            }

            int totalRecords = usersQuery.Count();
            var data = usersQuery.Skip(skip).Take(pageSize).ToList();

            return Json(new { draw = draw, recordsFiltered = totalRecords, recordsTotal = totalRecords, data = data });
        }
       
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] ApplicationUser user)
        {
            if (user.UserName == null || user.Email == null)
            {
                return BadRequest(new { success = false, message = "Invalid data" });
            }

            _context.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Your request has been submitted successfully!" });
        }

        // 3️ EDIT (GET FORM)
        public async Task<IActionResult> EditByIdUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            return View(user);
        }

        // 4️⃣ UPDATE (POST REQUEST)
        [HttpPost]
        public async Task<IActionResult> EditUser(string id, [Bind("Id,UserName,Email")] ApplicationUser user)
        {
            if (id != user.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
                return Ok(new { success = true, message = "User Updated successfully!" });
            }
            return View(user);
        }

        // 5️⃣ DELETE
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok(new { success = true, message = "User deleted successfully!" });
        }

    }
}
