using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public interface IReminderService
    {
        void InsertUser(User user);
        void AddReminderToUser(User user, Reminder reminder);
        void AddReminder(Reminder reminder);
        User RetrieveUser(string name);
        void CreateUser(string username, string email, string phone, string password, IList<Reminder> reminders);
        void SendNotification();
    }
}