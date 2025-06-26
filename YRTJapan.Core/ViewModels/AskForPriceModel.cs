using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRTJapan.Core.ViewModels
{
    public class AskForPriceModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}
