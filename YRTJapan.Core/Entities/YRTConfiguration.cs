using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTConfiguration : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string ConfigKey { get; set; }

        [Required]
        [Column(TypeName = "CHAR(1)")]
        public char ConfigValue { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        public string ConfigDesc { get; set; }
    }

}
