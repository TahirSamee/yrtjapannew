using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using YRTJapan.DataAccess.Data;

namespace YRTJapan.UI.Components
{
    public class CountryListViewComponent : ViewComponent
    {
        private readonly IMemoryCache _memoryCache;

        public CountryListViewComponent(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IViewComponentResult Invoke()
        {
            var countries = _memoryCache.GetOrCreate("CountryList", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(24);
                return CommonData.GetCountriesList; 
            });

            return View(countries);
        }
    }
}
