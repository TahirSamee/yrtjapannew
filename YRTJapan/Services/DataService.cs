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

namespace YRTJapan.UI.Services
{
    public class DataService : IDataService
    {
        private readonly ICacheService _cacheService;
        private readonly IApiService _apiService;
        private readonly IImageService _imageService;
        private readonly IMemoryCache _cache;

        public DataService(ICacheService cacheService, IApiService apiService, IImageService iImageService, IMemoryCache cache)
        {
            _cacheService = cacheService;
            _apiService = apiService;
            _imageService = iImageService;
            _cache = cache;
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
        public async Task<DropDownDataList> GetStockDataBySearchCriteriaAsync(CarSearchViewModel carSearch)
        {
            var response = await _apiService.RunMultipleQueriesAsync(StaticDetails.SQL_STOCK_PAGE(carSearch));
            if (response.IsSuccess && response.Data != null)
            {
                var dropdownData = new DropDownDataList();
                dropdownData.ListMakers = JsonConvert.DeserializeObject<List<Maker>>(response.Data[0].ToString());
                dropdownData.ListModels = JsonConvert.DeserializeObject<List<Model>>(response.Data[1].ToString());
                dropdownData.ListColors = JsonConvert.DeserializeObject<List<CarColor>>(response.Data[2].ToString());
                dropdownData.ListCars = JsonConvert.DeserializeObject<List<Car>>(response.Data[3].ToString());
                return dropdownData;
            }
            return new DropDownDataList();
        }
        public async Task<int> GetCarDataBySearchCriteriaCountAsync(CarSearchViewModel carSearch)
        {
            int totalLots = 0;
            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA_BY_SEARCH_CRITERIA_COUNT(carSearch));
            if (response.IsSuccess && response.Data != null)
            {
                totalLots = int.Parse(response.Data[0]["TAG0"].ToString());
            }
            return totalLots;
        }
        public async Task<List<Car>> GetCarDataBySearchCriteriaAsync(CarSearchViewModel  carSearch)
        {
            var response = await _apiService.AjGetAsync(StaticDetails.SQL_ALL_DATA_BY_SEARCH_CRITERIA(carSearch));
            if (response.IsSuccess && response.Data != null)
            {
                return JsonConvert.DeserializeObject<List<Car>>(response.Data.ToString());
            }
            return new List<Car>();
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
