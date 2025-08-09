using Microsoft.AspNetCore.Mvc;

namespace YRTJapan.UI.Components
{
    public class CountriesDropdownViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string selectId, string selectName, string selectStyle, bool isSelect2)
        {
            ViewData["SelectId"] = selectId;
            ViewData["SelectName"] = selectName;
            ViewData["SelectStyle"] = selectStyle;
            ViewData["IsSelect2"] = isSelect2;
            return View(); // It will look for Default.cshtml by default
        }
    }

}
