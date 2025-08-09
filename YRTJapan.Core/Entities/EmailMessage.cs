using MimeKit;

namespace YRTJapan.Core.Entities
{
    public class EmailMessage
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public EmailMessage(IEnumerable<string> to, string subject, string content)
        {
            this.To = new List<MailboxAddress>();
            this.To.AddRange(to.Select(x => new MailboxAddress("email", x)));
            this.Subject = subject;
            this.Content = content;
        }
    }
}
