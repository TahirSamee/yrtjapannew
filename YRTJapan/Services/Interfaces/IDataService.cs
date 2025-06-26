using YRTJapan.Core;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;

namespace YRTJapan.UI.Services.Interfaces
{
    public interface IDataService
    {
        Task<List<Maker>> GetMakersAsync();
        Task<List<Model>> GetModelsAsync();
        Task<List<Model>> GetModelsByMarkaNameAsync(string markaName);
        Task<List<ModelCode>> GetModelCodesBymodelNameAsync(string modelName);
        Task<List<Car>> GetCompleteCarDataAsync();
        Task<List<Car>> GetCarDataBySearchCriteriaAsync(CarSearchViewModel carSearch);
        Task<DropDownDataList> GetLandingPageDataAsync();
        Task<int> GetCarDataBySearchCriteriaCountAsync(CarSearchViewModel carSearch);
        Task<DropDownDataList> GetStockDataBySearchCriteriaAsync(CarSearchViewModel carSearch);
        //Task<List<Car>> GetCarDetailsByIdAsync(string id);
        Task<Car> GetCarDetailsByIdAsync(string id);
        Task<List<Car>> GetCarsAsync();
    }
}
