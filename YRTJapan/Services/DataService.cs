using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Cmp;
using System.Diagnostics.Metrics;
using System.Net.Http;
using PagedList;
using YRTJapan.Core;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;
using YRTJapan.UI.Services.Interfaces;
using YRTJapan.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

namespace YRTJapan.UI.Services
{
    public class DataService : IDataService
    {
        private readonly string _connectionString;
        private readonly ICacheService _cacheService;
        private readonly IApiService _apiService;
        private readonly IImageService _imageService;
        private readonly IMemoryCache _cache;

        public DataService(ICacheService cacheService, IApiService apiService, IImageService iImageService, IMemoryCache cache, IConfiguration configuration)
        {
            _cacheService = cacheService;
            _apiService = apiService;
            _imageService = iImageService;
            _cache = cache;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Maker>> GetMakersAsync()
        {
            return await _cache.GetOrCreateAsync("Makers", async entry =>
            {
                // Optionally, set cache options like expiration:
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(12);

                var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_MAKERS);
                if (response.IsSuccess && response.Data != null)
                {
                    var makers = JsonConvert.DeserializeObject<List<Maker>>(response.Data.ToString());
                    return makers ?? new List<Maker>();
                }
                return new List<Maker>();
            }) ?? new List<Maker>();
        }
        public async Task<List<Car>> GetCarsAsync()
        {
            return await _cache.GetOrCreateAsync("Cars", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);

                var response = await _apiService.AjGetAsync(StaticDetails.SQL_LANDING_PAGE_DATA);
                if (response.IsSuccess && response.Data != null)
                {
                    var cars = JsonConvert.DeserializeObject<List<Car>>(response.Data.ToString());
                    return cars ?? new List<Car>();
                }
                return new List<Car>();
            }) ?? new List<Car>();
        }
        public async Task<List<Model>> GetModelsAsync()
        {
            return await _cacheService.GetCachedDataAsync(
                $"ModelsCache",
                async () =>
                {
                    var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_MODELS);
                    if (response.IsSuccess && response.Data != null)
                    {
                        return JsonConvert.DeserializeObject<List<Model>>(response.Data.ToString());
                    }
                    return new List<Model>();
                });
        }
        public async Task<List<Model>> GetModelsByMarkaNameAsync(string markaName)
        {
            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_ModelsByMakerName(markaName));
            if (response.IsSuccess && response.Data != null)
            {
                return JsonConvert.DeserializeObject<List<Model>>(response.Data.ToString());
            }
            return new List<Model>();
        }
        public async Task<List<ModelCode>> GetModelCodesBymodelNameAsync(string modelName)
        {
            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_ModelCodesByModelName(modelName));
            if (response.IsSuccess && response.Data != null)
            {
                return JsonConvert.DeserializeObject<List<ModelCode>>(response.Data.ToString());
            }
            return new List<ModelCode>();
        }

        public async Task<List<Car>> GetCompleteCarDataAsync()
        {
            return await _cacheService.GetCachedDataAsync(
                $"CompleteCarDataCache",
                async () =>
                {
                    var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA);
                    if (response.IsSuccess && response.Data != null)
                    {
                        return JsonConvert.DeserializeObject<List<Car>>(response.Data.ToString());
                    }
                    return new List<Car>();
                });
        }

        public async Task<DropDownDataList> GetLandingPageDataAsync()
        {
            var response = await _apiService.RunMultipleQueriesAsync(StaticDetails.SQL_LANDING_PAGE());
            if (response.IsSuccess && response.Data != null)
            {
                var dropdownData = new DropDownDataList();
                dropdownData.ListMakers = JsonConvert.DeserializeObject<List<Maker>>(response.Data[0].ToString());
                dropdownData.ListModels = JsonConvert.DeserializeObject<List<Model>>(response.Data[1].ToString());
                dropdownData.ListCars = JsonConvert.DeserializeObject<List<Car>>(response.Data[2].ToString());
                return dropdownData;
            }
            return new DropDownDataList();
        }
        //public async Task<DropDownDataList> GetStockDataBySearchCriteriaAsync(CarSearchViewModel carSearch)
        //{
        //    var response = await _apiService.RunMultipleQueriesAsync(StaticDetails.SQL_STOCK_PAGE(carSearch));
        //    if (response.IsSuccess && response.Data != null)
        //    {
        //        var dropdownData = new DropDownDataList();
        //        dropdownData.ListMakers = JsonConvert.DeserializeObject<List<Maker>>(response.Data[0].ToString());
        //        dropdownData.ListModels = JsonConvert.DeserializeObject<List<Model>>(response.Data[1].ToString());
        //        dropdownData.ListColors = JsonConvert.DeserializeObject<List<CarColor>>(response.Data[2].ToString());
        //        dropdownData.ListCars = JsonConvert.DeserializeObject<List<Car>>(response.Data[3].ToString());
        //        return dropdownData;
        //    }
        //    return new DropDownDataList();
        //}
        public async Task<DropDownDataList> GetStockDataBySearchCriteriaAsync(CarSearchViewModel carSearch)
        {
            var dropdownData = new DropDownDataList();

            // 1. Always get local cars (strongly typed)
            List<Car> localCars = GetAllCars();

            // 2. Call API
            var response = await _apiService.RunMultipleQueriesAsync(StaticDetails.SQL_STOCK_PAGE(carSearch));

            if (response.IsSuccess && response.Data != null)
            {
                dropdownData.ListMakers = JsonConvert.DeserializeObject<List<Maker>>(response.Data[0]?.ToString() ?? "[]");
                dropdownData.ListModels = JsonConvert.DeserializeObject<List<Model>>(response.Data[1]?.ToString() ?? "[]");
                dropdownData.ListColors = JsonConvert.DeserializeObject<List<CarColor>>(response.Data[2]?.ToString() ?? "[]");

                // ✅ Ensure apiCars is strongly typed
                List<Car> apiCars = JsonConvert.DeserializeObject<List<Car>>(response.Data[3]?.ToString() ?? "[]");

                // ✅ Combine and deduplicate by ID
                dropdownData.ListCars = apiCars
                    .Concat(localCars)
                    .GroupBy(c => c.ID)
                    .Select(g => g.First())
                    .ToList();
            }
            else
            {
                // Fallback to local data only
                dropdownData.ListMakers = new List<Maker>();
                dropdownData.ListModels = new List<Model>();
                dropdownData.ListColors = new List<CarColor>();
                dropdownData.ListCars = localCars;
            }

            return dropdownData;
        }

        public async Task<int> GetCarDataBySearchCriteriaCountAsync(CarSearchViewModel carSearch)
        {
            int apiCount = 0;

            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA_BY_SEARCH_CRITERIA_COUNT(carSearch));

            if (response.IsSuccess && response.Data != null && response.Data.Count > 0)
            {
                var tagValue = response.Data[0]?["TAG0"]?.ToString();
                if (int.TryParse(tagValue, out int parsed))
                {
                    apiCount = parsed;
                }
            }

            // Get local cars from DB
            var localCars = GetAllCars();

            // Optional: filter localCars by search criteria if needed
            // Example: localCars = localCars.Where(c => c.MARKA_NAME == carSearch.Maker).ToList();

            int localCount = localCars.Count;

            // Combine both counts (optionally remove duplicates by ID if needed)
            return apiCount + localCount;
        }

        //public async Task<int> GetCarDataBySearchCriteriaCountAsync(CarSearchViewModel carSearch)
        //{
        //    int totalLots = 0;
        //    var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA_BY_SEARCH_CRITERIA_COUNT(carSearch));
        //    if (response.IsSuccess && response.Data != null)
        //    {
        //        totalLots = int.Parse(response.Data[0]["TAG0"].ToString());
        //    }
        //    return totalLots;
        //}
        //public async Task<List<Car>> GetCarDataBySearchCriteriaAsync(CarSearchViewModel carSearch)
        //{
        //    var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA_BY_SEARCH_CRITERIA(carSearch));
        //    if (response.IsSuccess && response.Data != null)
        //    {

        //        return JsonConvert.DeserializeObject<List<Car>>(response.Data.ToString());
        //    }
        //    return new List<Car>();
        //}
        public async Task<List<Car>> GetCarDataBySearchCriteriaAsync(CarSearchViewModel carSearch)
        {
            // Get API data
            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA_BY_SEARCH_CRITERIA(carSearch));
            var apiCars = new List<Car>();

            if (response.IsSuccess && response.Data != null)
            {
                apiCars = JsonConvert.DeserializeObject<List<Car>>(response.Data.ToString());
            }

            // Get admin-created/local database cars
            var localCars = GetAllCars();

            // Combine both lists
            var combinedCars = apiCars.Concat(localCars).ToList();

            return combinedCars;
        }

        public List<Car> GetAllCars()
        {
            var list = new List<Car>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Car", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var car = new Car
                        {
                            ID = reader["ID"].ToString(),
                            LOT = reader["LOT"].ToString(),
                            AUCTION_TYPE = reader["AUCTION_TYPE"].ToString(),
                            AUCTION_DATE = reader["AUCTION_DATE"].ToString(),
                            AUCTION = reader["AUCTION"].ToString(),
                            MARKA_ID = reader["MARKA_ID"].ToString(),
                            MODEL_ID = reader["MODEL_ID"].ToString(),
                            MARKA_NAME = reader["MARKA_NAME"].ToString(),
                            MODEL_NAME = reader["MODEL_NAME"].ToString(),
                            YEAR = reader["YEAR"].ToString(),
                            TOWN = reader["TOWN"].ToString(),
                            ENG_V = reader["ENG_V"].ToString(),
                            PW = reader["PW"].ToString(),
                            KUZOV = reader["KUZOV"].ToString(),
                            GRADE = reader["GRADE"].ToString(),
                            COLOR = reader["COLOR"].ToString(),
                            KPP = reader["KPP"].ToString(),
                            KPP_TYPE = reader["KPP_TYPE"].ToString(),
                            PRIV = reader["PRIV"].ToString(),
                            MILEAGE = reader["MILEAGE"].ToString(),
                            EQUIP = reader["EQUIP"].ToString(),
                            RATE = reader["RATE"].ToString(),
                            START = reader["START"].ToString(),
                            FINISH = reader["FINISH"].ToString(),
                            STATUS = reader["STATUS"].ToString(),
                            TIME = reader["TIME"].ToString(),
                            AVG_PRICE = reader["AVG_PRICE"].ToString(),
                            AVG_STRING = reader["AVG_STRING"].ToString(),
                            IMAGES = reader["IMAGES"].ToString(),
                            TAG2 = reader["TAG2"].ToString(),
                            carImages = GetCarImages(reader["ID"].ToString())
                        };

                        list.Add(car);
                    }
                }
            }

            return list;
        }
        private List<CarImage> GetCarImages(string carId)
        {
            var images = new List<CarImage>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM CarImages WHERE CarID = @CarID", conn);
                cmd.Parameters.AddWithValue("@CarID", carId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        images.Add(new CarImage
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            CarID = reader["CarID"].ToString(),
                            ImageUrl = reader["ImageUrl"].ToString()
                        });
                    }
                }
            }

            return images;
        }
        public async Task<Car> GetCarDetailsByIdAsync(string id)
        {
            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_CAR_DETAILS(id));
            if (response.IsSuccess && response.Data != null)
            {
                // Ensure proper deserialization
                var carList = JsonConvert.DeserializeObject<List<Car>>(response.Data.ToString());
                Car car = carList != null && carList.Count > 0 ? carList[0] : new Car();
                if (car != null)
                {
                    var imagesList = !string.IsNullOrEmpty(car.IMAGES) ? car.IMAGES.Split('#').ToList() : new List<string>();

                    // If there's at least one image, skip the main one and process the rest
                    if (imagesList.Count > 0)
                    {
                        car.IMAGES_LIST =  _imageService.FilterValidImageUrlsAsync(
                            imagesList.Count > 1 ? imagesList.Skip(1).ToList() : imagesList
                        );
                    }
                    else
                    {
                        car.IMAGES_LIST = new List<string>();
                    }
                }
                // Safely handle the list and return the first car or a new Car object
                return car;
            }
            return new Car();
        }

    }

}
