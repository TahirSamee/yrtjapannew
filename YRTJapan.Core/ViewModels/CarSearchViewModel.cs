using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRTJapan.Core.ViewModels
{
    public class CarSearchViewModel
    {
        public string MarkaName { get; set; }
        public string HomeMarkaName { get; set; }
        public string ModelName { get; set; }
        public string ModelCode { get; set; }
        public string FromYear { get; set; }
        public string ToYear { get; set; }
        public string FromPrice { get; set; }
        public string OverPrice { get; set; }
        public string ToPrice { get; set; }
        public string UnderPrice { get; set; }
        public string Type { get; set; }
        public string HomeTypeName { get; set; }        
        public string Engine { get; set; }
        public string Color { get; set; }
        public string MilageFrom { get; set; }
        public string MilageTo { get; set; }
        public string Transmission { get; set; }
        public string SearchKeyword { get; set; }
        public string HomeSearch { get; set; }
        public string Tab { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int Offset { get; set; }
        public int ItemsPerPage { get; set; }
    }
}
