using System.Collections.Generic;

namespace ReleaseReminder.SMTP.Service
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
        IList<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}