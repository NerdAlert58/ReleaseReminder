using System.Collections.Generic;

namespace ReleaseReminder.SMTP
{
    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddress>();
            FromAddresses = new List<EmailAddress>();
        }

        public IList<EmailAddress> ToAddresses { get; set; }
        public IList<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }

}