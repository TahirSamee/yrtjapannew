using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class Sale : BaseEntity
    {
        public string CarId { get; set; }
        public string UserId { get; set; }

        public float SalePrice { get; set; }

        public DateTime SaleDate { get; set; }
    }

}
