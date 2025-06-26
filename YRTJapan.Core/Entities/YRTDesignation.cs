using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTDesignation : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
    }

}
