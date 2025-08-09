using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YRTJapan.Core.Entities;

namespace YRTJapan.Core
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        public string? Gender { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(100)")]

        public string? FullName { get; set; }
        public int? CountryId { get; set; }
        public int? DesignationId { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public int? CompanyId { get; set; }
    }
}
