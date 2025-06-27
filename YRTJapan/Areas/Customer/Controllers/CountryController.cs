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
        public async Task<IActionResult> Zambia(CarSearchViewModel filters, int page = 1)
        {
            int itemsPerPage = 12;
            int offset = (page - 1) * itemsPerPage;

            var searchModel = new CarSearchViewModel
            {
                Offset = offset,
                ItemsPerPage = itemsPerPage,

                // Include filtering logic
                UnderPrice = !string.IsNullOrEmpty(filters.UnderPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(filters.UnderPrice)).Result.ToString("F0") : "",
                OverPrice = !string.IsNullOrEmpty(filters.OverPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(filters.OverPrice)).Result.ToString("F0") : "",
                MarkaName = filters.MarkaName ?? "",
                ModelName = filters.ModelName ?? "",
                FromYear = filters.FromYear ?? "",
                ToYear = filters.ToYear ?? "",
                FromPrice = !string.IsNullOrEmpty(filters.FromPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(filters.FromPrice)).Result.ToString("F0") : "",
                ToPrice = !string.IsNullOrEmpty(filters.ToPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(filters.ToPrice)).Result.ToString("F0") : "",
                Type = filters.Type ?? "",
                // add other filters as required
            };

            int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
            var response = await _dataService.GetStockDataBySearchCriteriaAsync(searchModel);

            response.ListCars = response.ListCars
                .Where(car => car.ID != "qml4jD38zfdWHY3")
                .Select(car =>
                {
                    if (int.TryParse(car.YEAR, out int carYear) && carYear > DateTime.Now.Year && !string.IsNullOrEmpty(car.AUCTION_DATE))
                        car.YEAR = DateTime.Parse(car.AUCTION_DATE).Year.ToString();

                    car.FOBPriceInUSD = CurrencyConverterLive.GetConvertedTotalBiggerPrice(car.AVG_PRICE, car.FINISH).Result;
                    car.FINISH = "";
                    return car;
                })
                .ToList();

            int totalPages = (int)Math.Ceiling((double)totalLots / itemsPerPage);

            ViewData["CurrentPage"] = page;
            ViewData["TotalLots"] = totalLots;
            ViewData["TotalPages"] = totalPages;
            ViewData["FromYear"] = filters.FromYear;
            ViewData["ToYear"] = filters.ToYear;
            ViewData["FromPrice"] = filters.FromPrice;
            ViewData["ToPrice"] = filters.ToPrice;
            ViewData["OverPrice"] = filters.OverPrice;
            ViewData["UnderPrice"] = filters.UnderPrice;
            ViewData["Type"] = filters.Type;
            ViewData["ModelName"] = filters.ModelName;
            ViewData["MarkaName"] = filters.MarkaName;

            // Required for dropdowns
            response.ListYears = CommonData.GetYearsList;
            response.ListFromPrices = CommonData.GetPriceFromList;
            response.ListToPrices = CommonData.GetPriceToList;
            response.ListBodyTypes = CommonData.GetAllBodyTypesList;
            response.ListFuel = CommonData.GetFuelList;
            response.ListTransmission = CommonData.GetTransmissionList;
            response.ListCountries = CommonData.GetCountriesList;

            return View("Zambia", response); // Make sure your View model is DropDownDataList
        }


        //public async Task<IActionResult> Zambia(int page = 1)
        //{
        //    int itemsPerPage = 12;
        //    int offset = (page - 1) * itemsPerPage;

        //    var searchModel = new CarSearchViewModel
        //    {
        //        Offset = offset,
        //        ItemsPerPage = itemsPerPage
        //    };

        //    // Get total car count and paginated car list
        //    int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
        //    var response = await _dataService.GetStockDataBySearchCriteriaAsync(searchModel);

        //    // Post-processing each car (e.g., price conversion, fixing year)
        //    response.ListCars = response.ListCars
        //        .Where(car => car.ID != "qml4jD38zfdWHY3")
        //        .Select(car =>
        //        {
        //            if (int.TryParse(car.YEAR, out int carYear) && carYear > DateTime.Now.Year && !string.IsNullOrEmpty(car.AUCTION_DATE))
        //            {
        //                car.YEAR = DateTime.Parse(car.AUCTION_DATE).Year.ToString();
        //            }

        //            car.FOBPriceInUSD = CurrencyConverterLive.GetConvertedTotalBiggerPrice(car.AVG_PRICE, car.FINISH).Result;
        //            car.FINISH = "";
        //            return car;
        //        })
        //        .ToList();

        //    int totalPages = (int)Math.Ceiling((double)totalLots / itemsPerPage);

        //    // ViewData for pagination
        //    ViewData["CurrentPage"] = page;
        //    ViewData["TotalLots"] = totalLots;
        //    ViewData["TotalPages"] = totalPages;

        //    return View(response.ListCars);
        //}

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
        public async Task<IActionResult> StockCars(int page, CarSearchViewModel searchModel)
        {
            if (!string.IsNullOrEmpty(searchModel.FromPrice))
                searchModel.FromPrice =
                    CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(searchModel.FromPrice))
                        .Result.ToString("F0");
            if (!string.IsNullOrEmpty(searchModel.ToPrice))
                searchModel.ToPrice =
                    CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(searchModel.ToPrice))
                        .Result.ToString("F0");

            var result = await GetStockCars(page, searchModel);
            result.carsList = result.carsList
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
            ViewData["TotalLots"] = result.TotalLots;
            ViewData["TotalCount"] = result.carsList.Count;
            ViewData["CurrentPage"] = page;
            var carListHtml = RenderPartialViewToString("_StockCars", result.carsList);
            var paginationHtml = RenderPartialViewToString("_PaginationPartial", new Pagination { CurrentPage = page, TotalPages = result.TotalPages });
            var totalLotsHtml = RenderPartialViewToString("_TotalLots", "Total Cars In Stock: " + result.TotalLots);
            var totalLots = result.TotalLots;
            var totalCars = ViewData["TotalCount"];
            return Json(new
            {
                cars = result.carsList.Select(car => new {
                    id = car.ID,
                    images = car.IMAGES,
                    marka = car.MARKA_NAME,
                    model = car.MODEL_NAME,
                    year = car.YEAR,
                    fob = car.FOBPriceInUSD,
                    finish = car.FINISH,
                    mileage = car.MILEAGE,
                    engine = car.ENG_V,
                    trans = car.KPP
                }),
                totalLots = result.TotalLots,
                currentPage = page,
                totalPages = result.TotalPages
            });

        }
        public async Task<(int TotalLots, int Offset, int TotalPages, List<Car> carsList)> GetStockCars(int page, CarSearchViewModel searchModel)
        {
            if (searchModel.Tab == "discountedStock")
            {
                searchModel.UnderPrice = CurrencyConverterLive.ConvertUSDToBidPriceInYen(CommonData.UnderPrice).Result.ToString("F0");
            }
            int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
            if (searchModel.Tab == "newArrival" && totalLots > CommonData.NewArrivalLotsLimit)
            {
                totalLots = CommonData.NewArrivalLotsLimit;
            }
            int itemsPerPage = 12;
            int offset = (page - 1) * itemsPerPage;
            int totalPages = (int)Math.Ceiling((double)totalLots / itemsPerPage);
            searchModel.Offset = offset;
            searchModel.ItemsPerPage = itemsPerPage;
            var filteredCars = await _dataService.GetCarDataBySearchCriteriaAsync(searchModel);
            return (totalLots, offset, totalPages, filteredCars);
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
