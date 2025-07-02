using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YRTJapan.Core.Entities;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.Utility;


namespace YRTJapan.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.ROLE_ADMIN)]
    public class StockController : Controller
    {
        private readonly IStock _stockRepo;

        public StockController(IStock stockRepo)
        {
            _stockRepo = stockRepo;
        }

        // ✅ View All Cars
        public IActionResult Index()
        {
            var cars = _stockRepo.GetAllCars();
            return View(cars);
        }

        // ✅ Show Create Form
        public IActionResult Create()
        {
            return View();
        }

        // ✅ Handle Form Submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car, List<IFormFile> files)
        {
            //if (ModelState.IsValid)
            //{
                car.ID = Guid.NewGuid().ToString(); // Generate primary key
                _stockRepo.AddCar(car, files);
                return RedirectToAction(nameof(Index));
           // }

            return View(car);
        }

        // ✅ Show Edit Form
        public IActionResult Edit(string id)
        {
            var car = _stockRepo.GetAllCars().FirstOrDefault(c => c.ID == id);
            return View(car);
        }

        // ✅ Handle Edit Submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _stockRepo.UpdateCar(car);
                return RedirectToAction(nameof(Index));
            }

            return View(car);
        }

        // ✅ Delete Car
        public IActionResult Delete(string id)
        {
            _stockRepo.DeleteCar(id);
            return RedirectToAction(nameof(Index));
        }
    }

}
