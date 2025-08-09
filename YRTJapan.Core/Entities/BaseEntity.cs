using System.ComponentModel.DataAnnotations;

namespace YRTJapan.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        public bool IsActive { get; set; }
        public string? CreatedById { get; set; }
        public string? UpdatedById { get; set; }
    }
}
