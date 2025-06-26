using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class API_Log : BaseEntity
    {

        [Column(TypeName = "VARCHAR(255)")]
        public string APIEndpoint { get; set; }

        public DateTime RequestTime { get; set; }

        public DateTime ResponseTime { get; set; }

        public int Status { get; set; }
    }

}
