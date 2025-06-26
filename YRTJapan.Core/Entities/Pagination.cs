using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRTJapan.Core.Entities
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string HomeMarkaName{ get; set; }
    }
}
