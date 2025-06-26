using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTMaker : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        public string LogoImg { get; set; }

        [Required]
        public bool IsGlobal { get; set; }
    }

}
