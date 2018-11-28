using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public interface IReminderService
    {
        bool AddReminderToUser(string user, IList<string> reminder);
        void AddReminder(Reminder reminder);
        User RetrieveUser(string name);
        void CreateUser(string username, string email, string phone, string password, IList<Reminder> reminders);
        void SendNotification();
        IList<Reminder> Display();
        IDictionary<Category, IDictionary<Genre, IList<Reminder>>> GetRemindersMap();
    }
}