using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class API_Configuration : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string APIKey { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Endpoint { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string? Description { get; set; }
    }

}
