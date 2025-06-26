using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using YRTJapan.Areas.Customer.Controllers;
using YRTJapan.Core;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;
using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.UI.Services;
using YRTJapan.UI.Services.Interfaces;
using YRTJapan.Utility;

namespace YRTJapan.UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class StockController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepo;
        private readonly IShoppingCartRepository _shoppingCartRepo;
        private readonly IDataService _dataService;
        private readonly IApiService _apiService;
        private readonly ICompositeViewEngine _viewEngine;
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;
        public StockController(ILogger<HomeController> logger, IProductRepository productRepo, IShoppingCartRepository shoppingCartRepo,
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
        //     public async Task<IActionResult> Index(int currentPage=1, string markaName=null)
        public async Task<IActionResult> Index(CarSearchViewModel homeCarFilters, string tab = "stock")

        {
            //homeCarFilters.FromPrice = homeCarFilters.FromPrice != null ? await CurrencyConverter.
            if (tab == "discountedStock")
            {
                homeCarFilters.UnderPrice = CommonData.UnderPrice.ToString("F0");
            }
            var searchModel = new CarSearchViewModel
            {
                // Only add the filter if the corresponding value is provided
                UnderPrice = !string.IsNullOrEmpty(homeCarFilters.UnderPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(CommonData.UnderPrice).Result.ToString("F0") : string.Empty,
                OverPrice = !string.IsNullOrEmpty(homeCarFilters.OverPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(homeCarFilters.OverPrice)).Result.ToString("F0") : string.Empty,
                HomeMarkaName = !string.IsNullOrEmpty(homeCarFilters.HomeMarkaName) ? homeCarFilters.HomeMarkaName : string.Empty,
                HomeTypeName = !string.IsNullOrEmpty(homeCarFilters.HomeTypeName) ? homeCarFilters.HomeTypeName : string.Empty,
                MarkaName = !string.IsNullOrEmpty(homeCarFilters.MarkaName) ? homeCarFilters.MarkaName : string.Empty,
                ModelName = !string.IsNullOrEmpty(homeCarFilters.ModelName) ? homeCarFilters.ModelName : string.Empty,
                FromPrice = !string.IsNullOrEmpty(homeCarFilters.FromPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(homeCarFilters.FromPrice)).Result.ToString("F0") : string.Empty,
                ToPrice = !string.IsNullOrEmpty(homeCarFilters.ToPrice) ? CurrencyConverterLive.ConvertUSDToBidPriceInYen(Convert.ToDecimal(homeCarFilters.ToPrice)).Result.ToString("F0") : string.Empty,
                FromYear = !string.IsNullOrEmpty(homeCarFilters.FromYear) ? homeCarFilters.FromYear : string.Empty,
                ToYear = !string.IsNullOrEmpty(homeCarFilters.ToYear) ? homeCarFilters.ToYear : string.Empty,
                Type = !string.IsNullOrEmpty(homeCarFilters.Type) ? homeCarFilters.Type : string.Empty,
                Offset = 0,
                ItemsPerPage = CommonData.PageSize
            };


            int currentPage = 1;
            int totalLots = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
            if (tab == "newArrival" && totalLots > CommonData.NewArrivalLotsLimit)
            {
                totalLots = CommonData.NewArrivalLotsLimit;
            }

            int totalPages = (int)Math.Ceiling((double)totalLots / searchModel.ItemsPerPage);
            var response = await _dataService.GetStockDataBySearchCriteriaAsync(searchModel);
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



            response.ListBodyTypes = CommonData.GetAllBodyTypesList;
            response.ListYears = CommonData.GetYearsList;
            response.ListFromPrices = CommonData.GetPriceFromList;
            response.ListToPrices = CommonData.GetPriceToList;
            response.ListFuel = CommonData.GetFuelList;
            response.ListTransmission = CommonData.GetTransmissionList;
            response.ListCountries = CommonData.GetCountriesList;
            if (homeCarFilters.HomeMarkaName != null)
            {
                ViewData["HomeMarkaName"] = homeCarFilters.HomeMarkaName.ToUpper();
            }
            ViewData["TotalCarsInStock"] = "Total Cars In Stock: " + totalLots;
            ViewData["TotalLots"] = totalLots;
            ViewData["CurrentPage"] = currentPage;
            ViewData["SelectedHomeFilterMarkaName"] = homeCarFilters.HomeMarkaName;
            ViewData["FromYear"] = homeCarFilters.FromYear;
            ViewData["ToYear"] = homeCarFilters.ToYear;
            ViewData["FromPrice"] = homeCarFilters.FromPrice;
            ViewData["ToPrice"] = homeCarFilters.ToPrice;
            ViewData["OverPrice"] = homeCarFilters.OverPrice;
            ViewData["UnderPrice"] = homeCarFilters.UnderPrice;
            ViewData["Type"] = homeCarFilters.Type;
            ViewData["HomeTypeName"] = homeCarFilters.HomeTypeName;
            ViewData["ModelName"] = homeCarFilters.ModelName;
            ViewData["MarkaName"] = homeCarFilters.MarkaName;
            var carListHtml = RenderPartialViewToString("_StockCars", response.ListCars);
            var paginationHtml = RenderPartialViewToString("_PaginationPartial", new Pagination { CurrentPage = currentPage, TotalPages = totalPages });
            ViewData["CarListHtml"] = carListHtml;
            ViewData["PaginationHtml"] = paginationHtml;
            ViewData["ActiveTab"] = tab;
            return View(response);
        }

        public async Task<IActionResult> Details(string id)
        {

            var imageDetails = await _dataService.GetCarDetailsByIdAsync(id);
            imageDetails.FOBPriceInUSD = CurrencyConverterLive.GetConvertedTotalBiggerPrice(imageDetails.AVG_PRICE, imageDetails.FINISH).Result;
            imageDetails.GRADE = CleanGrade(imageDetails.GRADE);
            imageDetails.PRIV = CleanPriv(imageDetails.PRIV);
            return View(imageDetails);
        }
        public static string CleanGrade(string grade)
        {
            if (string.IsNullOrWhiteSpace(grade))
                return grade;

            // Step 1: Remove HTML numeric entities (e.g. "&#24555;")
            grade = Regex.Replace(grade, @"&#\d+;", "");

            // Step 2: Remove specific substring "4&" (case-insensitive)
            grade = Regex.Replace(grade, Regex.Escape("4&"), "", RegexOptions.IgnoreCase);

            // Step 3: Remove words "Style" and "Package" using word boundaries (case-insensitive)
            grade = Regex.Replace(grade, @"\b(?:Style|Package)\b", "", RegexOptions.IgnoreCase);

            // Step 4: Remove any occurrences of "&#" if still present
            grade = grade.Replace("&#", "");

            // Step 5: Remove individual unwanted characters: &, #, ;, +
            grade = Regex.Replace(grade, @"[&#;+]", "");

            // Step 6: Remove extra whitespace
            grade = Regex.Replace(grade, @"\s+", " ").Trim();

            return grade;
        }

        public static string CleanPriv(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            // Trim leading/trailing whitespace.
            string trimmed = input.Trim();

            // If the value is exactly "FF", return it unchanged.
            if (trimmed.Equals("FF", StringComparison.OrdinalIgnoreCase))
                return trimmed;

            // Step 1: Remove a leading "FF," (with optional spaces after the comma)
            string result = Regex.Replace(trimmed, @"^FF,\s*", "", RegexOptions.IgnoreCase);

            // Step 2: Insert a space between "FULLTIME" and "4WD" or "2WD" if needed.
            // This replaces, for example, "FULLTIME4WD" with "FULLTIME 4WD"
            result = Regex.Replace(result, @"(FULLTIME)(\dWD)", "$1 $2", RegexOptions.IgnoreCase);

            // Step 3: Remove any stray commas that might remain.
            result = result.Replace(",", "");

            return result.Trim();
        }

        public async Task<IActionResult> GetModels(string markaName)
        {
            var response = await _dataService.GetModelsByMarkaNameAsync(markaName);
            return PartialView("_ModelsDropdown", response);
        }
        public async Task<IActionResult> GetModelCodes(string modelName)
        {
            var response = await _dataService.GetModelCodesBymodelNameAsync(modelName);
            return PartialView("_ModelCodeDropdown", response);
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
            return Json(new { carListHtml, paginationHtml, totalLots, totalLotsHtml });
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
            int itemsPerPage = CommonData.PageSize;
            int offset = (page - 1) * itemsPerPage;
            int totalPages = (int)Math.Ceiling((double)totalLots / itemsPerPage);
            searchModel.Offset = offset;
            searchModel.ItemsPerPage = itemsPerPage;
            var filteredCars = await _dataService.GetCarDataBySearchCriteriaAsync(searchModel);
            return (totalLots, offset, totalPages, filteredCars);
        }

        public IActionResult AddToFavourites(Favourite favourite)
        {

            _context.Favourites.Add(favourite);
            _context.SaveChanges();

            return Json(new { success = true, message = "Added to favourites!" });
        }

        [HttpPost]
        public async Task<IActionResult> FreeQuote1([FromBody] FreeQuote quote)
        {
            if (quote.Name == null || quote.Country == null || quote.PhoneNumber == null || quote.Email == null)
            {
                return BadRequest(new { success = false, message = "Invalid data" });
            }

            _context.Add(quote);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Your quote request has been submitted successfully!" });
        }

        [HttpPost]
        public async Task<IActionResult> SubmitInquiries([FromBody] SalesInquiryModel inquiryvalues)
        {
            if (ModelState.IsValid)
            {
                // Manually map the model to the entity
                var salesInquiry = new SalesInquiries
                {
                    Make = inquiryvalues.Make,
                    Model = inquiryvalues.Model,
                    Year = inquiryvalues.Year,
                    Price = inquiryvalues.Price,
                    Email = inquiryvalues.Email,
                    Message = inquiryvalues.Message,
                    Country = inquiryvalues.Country,
                    CarId = inquiryvalues.CarId
                };

                _context.Add(salesInquiry);
                await _context.SaveChangesAsync();
                return Json(new { success = true });
            }
            return Json(new { success = false, message = "Invalid data" });
        }

        [HttpPost]
        public async Task<IActionResult> SubmitAskForPrice([FromBody] AskForPriceModel askForValues)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var askObj = new AskForPriceModel
                    {
                        Make = askForValues.Make,
                        Model = askForValues.Model,
                        Year = askForValues.Year,
                        Name = askForValues.Name,
                        Email = askForValues.Email,
                        Phone = askForValues.Phone,
                        Country = askForValues.Country
                    };
                    var emailBody = $@"
                                <html>
                                <head>
                                    <meta charset='UTF-8'>
                                    <style>
                                    body {{
                                        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                                        background-color: #f7f7f7;
                                        margin: 0;
                                        padding: 0;
                                    }}
                                    .container {{
                                        max-width: 600px;
                                        margin: 30px auto;
                                        background-color: #ffffff;
                                        padding: 20px;
                                        border-radius: 8px;
                                        box-shadow: 0 2px 5px rgba(0,0,0,0.1);
                                    }}
                                    h2 {{
                                        color: #333333;
                                        border-bottom: 2px solid #e2e2e2;
                                        padding-bottom: 10px;
                                    }}
                                    p {{
                                        line-height: 1.6;
                                        color: #555555;
                                    }}
                                    .details {{
                                        width: 100%;
                                        margin: 20px 0;
                                        border-collapse: collapse;
                                    }}
                                    .details th, .details td {{
                                        text-align: left;
                                        padding: 8px 12px;
                                        border-bottom: 1px solid #f0f0f0;
                                    }}
                                    .details th {{
                                        background-color: #fafafa;
                                        font-weight: bold;
                                        width: 35%;
                                    }}
                                    .footer {{
                                        font-size: 12px;
                                        color: #999999;
                                        text-align: center;
                                        margin-top: 20px;
                                    }}
                                    </style>
                                </head>
                                <body>
                                    <div class='container'>
                                    <h2>Ask For Price Request</h2>
                                    <p>You have received a new inquiry for a car price. The details are as follows:</p>
                                    <table class='details'>
                                        <tr>
                                        <th>Car Make:</th>
                                        <td>{askObj.Make}</td>
                                        </tr>
                                        <tr>
                                        <th>Car Model:</th>
                                        <td>{askObj.Model}</td>
                                        </tr>
                                        <tr>
                                        <th>Car Year:</th>
                                        <td>{askObj.Year}</td>
                                        </tr>
                                        <tr>
                                        <th>Name:</th>
                                        <td>{askObj.Name}</td>
                                        </tr>
                                        <tr>
                                        <th>Email:</th>
                                        <td>{askObj.Email}</td>
                                        </tr>
                                        <tr>
                                        <th>Phone:</th>
                                        <td>{askObj.Phone}</td>
                                        </tr>
                                        <tr>
                                        <th>Country:</th>
                                        <td>{askObj.Country}</td>
                                        </tr>
                                    </table>
                                    <p>Please follow up on this request at your earliest convenience.</p>
                                    <div class='footer'>
                                        <p>&copy; {DateTime.Now.Year} YRT Japan. All rights reserved.</p>
                                    </div>
                                    </div>
                                </body>
                                </html>
                                ";

                    // Send the email to the designated recipient.
                    await _emailSender.SendEmailAsync("info@yrtjapan.com", "Ask For Price", emailBody);
                    return Json(new { success = true });
                }

            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = false, message = "Invalid data" });
        }
    }
}
