using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRTJapan.Core.Entities
{
    public class Favourite
    {
        public int Id { get; set; }
        public string ImageLink { get; set; }
        public string MakeName { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
    }
}
