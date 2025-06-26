using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using YRTJapan.Areas.Customer.Controllers;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;
using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.UI.Services.Interfaces;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CountryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepo;
        private readonly IShoppingCartRepository _shoppingCartRepo;
        private readonly IDataService _dataService;
        private readonly IApiService _apiService;
        private readonly ICompositeViewEngine _viewEngine;
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;
        public CountryController(ILogger<HomeController> logger, IProductRepository productRepo, IShoppingCartRepository shoppingCartRepo,
                               IDataService dataService, IApiService apiService, ICompositeViewEngine viewEngine, ApplicationDbContext context, IEmailSender emailSender)
        {
            _logger = logger;
            _productRepo = productRepo;
            _shoppingCartRepo = shoppingCartRepo;
            _dataService = dataService;
            _apiService = apiService;
            _viewEngine = viewEngine;
            _context = context;
            _emailSender = emailSender;
        }
        public async Task<IActionResult> Zambia(int page = 1)
        {
            int itemsPerPage = 12;
            int offset = (page - 1) * itemsPerPage;

            var searchModel = new CarSearchViewModel
            {
                Offset = offset,
                ItemsPerPage = itemsPerPage
            };

            // Get total car count and paginated car list
            int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
            var response = await _dataService.GetStockDataBySearchCriteriaAsync(searchModel);

            // Post-processing each car (e.g., price conversion, fixing year)
            response.ListCars = response.ListCars
                .Where(car => car.ID != "qml4jD38zfdWHY3")
                .Select(car =>
                {
                    if (int.TryParse(car.YEAR, out int carYear) && carYear > DateTime.Now.Year && !string.IsNullOrEmpty(car.AUCTION_DATE))
                    {
                        car.YEAR = DateTime.Parse(car.AUCTION_DATE).Year.ToString();
                    }

                    car.FOBPriceInUSD = CurrencyConverterLive.GetConvertedTotalBiggerPrice(car.AVG_PRICE, car.FINISH).Result;
                    car.FINISH = "";
                    return car;
                })
                .ToList();

            int totalPages = (int)Math.Ceiling((double)totalLots / itemsPerPage);

            // ViewData for pagination
            ViewData["CurrentPage"] = page;
            ViewData["TotalLots"] = totalLots;
            ViewData["TotalPages"] = totalPages;

            return View(response.ListCars);
        }

        public IActionResult Tanzania()
        {
            return View();
        } 
        public IActionResult Kenya()
        {
            return View();
        }
        public IActionResult DRCongo()
        {
            return View();
        }
        private string RenderPartialViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = _viewEngine.FindView(ControllerContext, viewName, false);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw, new HtmlHelperOptions());
                viewResult.View.RenderAsync(viewContext).Wait();
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
