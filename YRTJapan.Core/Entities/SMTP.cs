namespace YRTJapan.Core.Entities
{
    public class SMTP
    {
        public string MAIL_FROM { get; set; } = null!;
        public string MAIL_SMTP_SERVER { get; set; } = null!;
        public int MAIL_PORT { get; set; }
        public string MAIL_USERNAME { get; set; } = null!;
        public string MAIL_PASSWORD { get; set; } = null!;
    }
}
