using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRTJapan.Core.Entities
{
    public class FreeQuote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string CarId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
