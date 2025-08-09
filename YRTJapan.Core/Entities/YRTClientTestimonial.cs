using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTClientTestimonial : BaseEntity
    {
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string UserName { get; set; }

        public string UserComments { get; set; }

        [Required]
        public int UserScore { get; set; }

        [Column(TypeName = "NVARCHAR(200)")]
        public string UserImg { get; set; }

        [Required]
        public bool IsVarified { get; set; }
    }

}
