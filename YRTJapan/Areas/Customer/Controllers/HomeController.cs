using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;
using System.Security.Claims;
using YRTJapan.Core;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;
using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.UI.Areas.Customer.Controllers;
using YRTJapan.UI.Helper;
using YRTJapan.UI.Services.Interfaces;
using YRTJapan.Utility;

namespace YRTJapan.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepo;
        private readonly IShoppingCartRepository _shoppingCartRepo;
        private readonly IDataService _dataService;
        private readonly ApplicationDbContext _context;
        private readonly ICompositeViewEngine _viewEngine;
        public HomeController(ILogger<HomeController> logger, IProductRepository productRepo, IShoppingCartRepository shoppingCartRepo, IDataService dataService, ApplicationDbContext context, ICompositeViewEngine viewEngine)
        {
            _logger = logger;
            _productRepo = productRepo;
            _shoppingCartRepo = shoppingCartRepo;
            _dataService = dataService;
            _context = context;
            _viewEngine = viewEngine;
        }

        public async Task<IActionResult> Index()
        {
            //var carsDataConpleted = await _dataService.GetCompleteCarDataAsync();
            var response = new DropDownDataList();
            var makersList = await _dataService.GetMakersAsync();
            var carList = await _dataService.GetCarsAsync();
            carList = carList
                        .Where(car => int.TryParse(car.YEAR, out int carYear) && carYear <= DateTime.Now.Year && car.ID != "qml4jD38zfdWHY3")
                        .Select(car =>
                        {
                            car.FOBPriceInUSD = CurrencyConverterLive.GetConvertedTotalBiggerPrice(car.AVG_PRICE, car.FINISH).Result;
                            return car;
                        })
                        .ToList();
            var searchModel = new CarSearchViewModel
            {
            };
            int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
            //response.ListBodyTypes = CommonData.GetAllBodyTypesList.Take(6).ToList();
            //response.ListJapenesMakers = CommonData.GetJapenesMakersList.Take(6).ToList();
            //response.ListGlobalMakers = CommonData.GetGlobalMakerList.Take(6).ToList();
            //response.ListYears = CommonData.GetYearsList;
            //response.ListFromPrices = CommonData.GetPriceFromList;
            //response.ListCountries = CommonData.GetCountriesList.Take(10).ToList();
            //response.ListToPrices = CommonData.GetPriceToList;
            response.ListCars = carList;
            response.ListMakers = makersList;
            response.ListFavourites = await _context.Favourites.ToListAsync();
            ViewData["TotalCarsInStock"] = "Total Cars In Stock: " + totalLots;
            return View(response);
        }

        public async Task<IActionResult> GetModels(string markaName)
        {

            var response = await _dataService.GetModelsByMarkaNameAsync(markaName);
            return PartialView("_HomeModelDropDown", response);
        }

        [HttpPost]
        public async Task<IActionResult> SearchCars(CarSearchViewModel searchModel)
        {
            try
            {
                if(!string.IsNullOrEmpty(searchModel.FromPrice))
                    searchModel.FromPrice =
                        CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(searchModel.FromPrice))
                                .Result.ToString("F0");
                if (!string.IsNullOrEmpty(searchModel.ToPrice))
                    searchModel.ToPrice =
                        CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(searchModel.ToPrice))
                                .Result.ToString("F0");

                decimal exchangeRateToYen = CurrencyConverterLive.GetJPYToUSDExchangeRateAsync().Result;

                if (decimal.TryParse(searchModel.UnderPrice, out decimal underPriceUSD))
                {
                    searchModel.UnderPrice = CurrencyConverterLive.ConvertUSDToBidPriceInYen(underPriceUSD).Result.ToString("F0");
                }

                if (decimal.TryParse(searchModel.OverPrice, out decimal overPriceUSD))
                {
                    searchModel.OverPrice = CurrencyConverterLive.ConvertUSDToBidPriceInYen(overPriceUSD).Result.ToString("F0");
                }
              
                int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(new CarSearchViewModel{ });
                int itemsPerPage = 16;
                int offset = (1 - 1) * itemsPerPage;
                int totalPages = (int)Math.Ceiling((double)totalLots / itemsPerPage);

                searchModel.Offset = offset;
                searchModel.ItemsPerPage = itemsPerPage;

                var filteredCars = await _dataService.GetCarDataBySearchCriteriaAsync(searchModel);
                filteredCars = filteredCars
                    .Select(car =>
                    {
                        if (int.TryParse(car.YEAR, out int carYear) && carYear > DateTime.Now.Year && !string.IsNullOrEmpty(car.AUCTION_DATE))
                        {
                            car.YEAR = DateTime.Parse(car.AUCTION_DATE).Year.ToString();
                        }
                        car.FOBPriceInUSD = CurrencyConverterLive.GetConvertedTotalBiggerPrice(car.AVG_PRICE, car.FINISH).Result;
                        return car;
                    })
                    .ToList();
                var totalLotsHtml = await RenderPartialViewToStringAsync("_TotalLots", "Total Cars In Stock: " + totalLots);
                var carCardsHtml = await RenderPartialViewToStringAsync("_CarCards", filteredCars.ToList());

                // Return a JSON object containing both fragments
                return Json(new { totalLots = totalLotsHtml, carCards = carCardsHtml });


                return PartialView("_CarCards", filteredCars.ToList());
            }
            catch (Exception ex)
            {
                // Log the error (consider using a logging framework like Serilog, NLog, or built-in ILogger)
                _logger.LogError(ex, "Error occurred while searching for cars.");

                // Optionally return an error response or an empty view with a message
                return PartialView("_CarCards", new List<Car>());
            }
        }

        protected async Task<string> RenderPartialViewToStringAsync(string viewName, object model)
        {
            ViewData.Model = model;
            using (var writer = new StringWriter())
            {
                var viewResult = _viewEngine.FindView(ControllerContext, viewName, false);
                if (viewResult.View == null)
                {
                    throw new ArgumentNullException($"{viewName} does not match any available view");
                }
                var viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    ViewData,
                    TempData,
                    writer,
                    new HtmlHelperOptions()
                );
                await viewResult.View.RenderAsync(viewContext);
                return writer.GetStringBuilder().ToString();
            }
        }
        public IActionResult Details(Guid productId)
        {
            ShoppingCart shoppingCart = new ShoppingCart()
            {
                Product = _productRepo.Get(u => u.Id == productId, includeProperties: "Category"),
                Count = 1,
                ProductId = productId
            };
            return View(shoppingCart);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId = userId;

            ShoppingCart cartDb = _shoppingCartRepo.Get(u => u.ApplicationUserId == userId && u.ProductId == shoppingCart.ProductId);
            Product product = _productRepo.Get(u => u.Id == shoppingCart.ProductId);

            if (cartDb == null)
            {
                _shoppingCartRepo.Add(shoppingCart);
            }
            else
            {
                cartDb.Count += shoppingCart.Count;
                _shoppingCartRepo.Update(cartDb);
            }

            _shoppingCartRepo.Save();
            TempData["success"] = $"{product.Title} is added to the cart";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult GetFavouriteCars(int page = 1, int pageSize = 3)
        {
            var cars = _context.Favourites
                        .OrderByDescending(c => c.Id) // Descending order
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

            return Json(cars);
        }

        [HttpGet]
        public JsonResult LoadMoreCountries(int offset)
        {
            var allCountries = DropdownHelper.GetCountriesList.Skip(offset).Take(5).ToList();
            return Json(allCountries);
        }
        [HttpGet]
        public JsonResult LoadMoreJapenesMakers(int offset, bool all = false)
        {
            var japenesMakers = all ? DropdownHelper.GetJapenesMakersList.ToList() : DropdownHelper.GetJapenesMakersList.Skip(offset).Take(5).ToList();
            return Json(japenesMakers);
        }


        [HttpGet]
        public JsonResult LoadMoreGlobalMakers(int offset, bool all = false)
        {
            var globalMakers = all ? DropdownHelper.GetGlobalMakerList.ToList() : DropdownHelper.GetGlobalMakerList.Skip(offset).Take(5).ToList();
            return Json(globalMakers);
        }


        [HttpGet]
        public JsonResult LoadMoreBodyTypes(int offset, bool all = false)
        {
            var bodyTypes = all ? DropdownHelper.GetDropdownBodyTypesList : DropdownHelper.GetDropdownBodyTypesList.Skip(offset).Take(5).ToList();
            return Json(bodyTypes);
        }

    }
}
