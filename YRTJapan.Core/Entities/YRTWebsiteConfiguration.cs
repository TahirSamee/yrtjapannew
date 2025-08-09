using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTWebsiteConfiguration : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string WebConfigTitle { get; set; }

        public string WebConfigDesc { get; set; }

        [StringLength(200)]
        public string WebConfigImage { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string WebPageName { get; set; }
    }

}
