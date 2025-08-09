using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YRTJapan.Core.Entities
{
    public class DashboardSetting : BaseEntity
    {
        public string UserId { get; set; }

        public string? SettingJSON { get; set; }
    }

}
