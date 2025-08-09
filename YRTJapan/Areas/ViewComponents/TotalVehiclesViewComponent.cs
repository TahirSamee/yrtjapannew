using Microsoft.AspNetCore.Mvc;
using YRTJapan.Core.ViewModels;
using YRTJapan.DataAccess.Data;
using YRTJapan.UI.Services.Interfaces;
using System.Threading.Tasks;

namespace YRTJapan.UI.Areas.ViewComponents
{
    public class TotalVehiclesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly IDataService _dataService;

        public TotalVehiclesViewComponent(IDataService dataService, ApplicationDbContext context)
        {
            _context = context;
            _dataService = dataService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var searchModel = new CarSearchViewModel();
            int totalVehicles = await _dataService.GetCarDataBySearchCriteriaCountAsync(searchModel);
            return View(totalVehicles);
        }
    }
}
