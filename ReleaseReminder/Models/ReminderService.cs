using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public class ReminderService : IReminderService
    {
        private IReminderProvider _reminderProvider = null;
        private IList<Reminder> _reminders = null;
        private IDictionary<Category, IDictionary<Genre, IList<Reminder>>> _remindersMap = null;
        private IDictionary<string, User> _users = null;
        public ReminderService(IReminderProvider reminderProvider)
        {
            _reminderProvider = reminderProvider ?? throw new System.ArgumentNullException(nameof(reminderProvider));
            _users = new Dictionary<string, User>();
            _reminders = _reminderProvider.Reminders();
            _remindersMap = _reminderProvider.RemindersMap();
        }

        public void AddReminder(Reminder reminder)
        {
            _reminders.Add(reminder);
        }

        public void AddReminderToUser(User user, Reminder reminder)
        {
            if (_users.TryGetValue(user.Username, out var matched))
            {
                if (!matched.Reminders.Contains(reminder))
                {
                    matched.Reminders.Add(reminder);
                }
            }
        }

        public void CreateUser(string username, string email, string phone, string password, IList<Reminder> reminders)
        {
            if (_users.TryGetValue(username, out var user))
            {
                System.Console.WriteLine($"{username} is already in use.");
            }
        }

        public void InsertUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public User RetrieveUser(string name)
        {
            throw new System.NotImplementedException();
        }

        public void SendNotification()
        {
            throw new System.NotImplementedException();
        }
    }
}