using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTCountry : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(5)")]
        public string Code { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        public string LogoImg { get; set; }
    }

}
