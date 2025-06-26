using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class YRTBankAccount : BaseEntity
    {

        [Required]
        [Column(TypeName = "VARCHAR(100)")]
        public string BankName { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Telex { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        public string AccountNumber { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(25)")]
        public string IBAN { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        public string SwiftCode { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string? Address { get; set; }
    }

}
