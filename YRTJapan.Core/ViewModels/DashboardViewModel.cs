using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YRTJapan.Core.Entities;

namespace YRTJapan.Core.ViewModels
{
    public class DashboardViewModel
    {
        public List<FreeQuote> Quotes { get; set; }
        public List<Favourite> Favourites { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}
