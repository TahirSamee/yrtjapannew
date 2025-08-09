using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRTJapan.Core.ViewModels
{
    public class SalesInquiryModel
    {
        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Message { get; set; }
        public string Country { get; set; }
        [Required]
        public string CarId { get; set; }
    }
}
