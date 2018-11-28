using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReleaseReminder.SMTP;
using ReleaseReminder.SMTP.Service;

namespace ReleaseReminder.Models
{
    public class ReminderService : IReminderService
    {
        private IReminderProvider _reminderProvider = null;
        private IList<Reminder> _reminders = null;
        private IDictionary<Category, IDictionary<Genre, IList<Reminder>>> _remindersMap = null;
        private IDictionary<string, User> _users = null;
        private IDictionary<string, IList<User>> _usersByTitle = null;
        private IDictionary<string, Reminder> _remindersByTitle = null;
        private IEmailService _emailService = null;
        private string _currentUser = "";
        public ReminderService(IReminderProvider reminderProvider, IEmailService emailService)
        {
            _reminderProvider = reminderProvider ?? throw new System.ArgumentNullException(nameof(reminderProvider));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _users = new Dictionary<string, User>();
            _usersByTitle = new Dictionary<string, IList<User>>();
            _reminders = _reminderProvider.Reminders();
            _remindersMap = _reminderProvider.RemindersMap();
            _remindersByTitle = _reminderProvider.RemindersByTitle();
        }

        public void AddReminder(Reminder reminder)
        {
            _reminders.Add(reminder);
        }

        public bool AddReminderToUser(string username, IList<string> titles)
        {
            if (string.IsNullOrEmpty(username))
            {
                username = _currentUser;
            }

            if (!_users.TryGetValue(username, out var user)) return false;
            if (titles == null || titles.Count <= 0) return false;

            var newReminders = new List<Reminder>();

            for (int i = 0; i < titles.Count; i++)
            {
                var title = titles[i];
                if (!_remindersByTitle.TryGetValue(title, out var reminder)) continue;

                if (!user.Reminders.Contains(reminder))
                {
                    user.Reminders.Add(reminder);
                    newReminders.Add(reminder);
                }
            }

            SendAddedRemindersEmail(user, newReminders);
            return true;
        }

        public IList<Reminder> UserNewReminders()
        {
            if (_users.TryGetValue(_currentUser, out var user))
            {
                return user.Reminders;
            }

            return null;
        }

        private void SendAddedRemindersEmail(User user, IList<Reminder> reminders)
        {
            var sb = new StringBuilder();
            reminders.ToList().Sort((a, b) => a.ReleaseDate.CompareTo(b.ReleaseDate));
            for (int i = 0; i < reminders.Count; i++)
            {
                var reminder = reminders[i];
                sb.Append($"{reminder.ReleaseDate.ToString("yyyy-MM-dd")}   -----   {reminder.Title}");
                if (i < reminders.Count - 1)
                {
                    sb.Append("<br/>");
                }
            }

            var email = new EmailMessage()
            {
                ToAddresses = new List<EmailAddress>() { new EmailAddress() { Name = user.Username, Address = user.Email } },
                FromAddresses = new List<EmailAddress>() { new EmailAddress() { Name = "ReleaseReminder", Address = "releasereminder2018@gmail.com" } },
                Subject = $"Hello {user.Username}!  Release Reminder Subscription notification.",
                Content = sb.ToString()
            };
            _emailService.Send(email);
        }

        public void CreateUser(string username, string email, string phone, string password, IList<Reminder> reminders)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password)) return;
            if (_users.TryGetValue(username, out var userAlreadyExists))
            {
                System.Console.WriteLine($"{username} is already in use.");
                return;
            }

            if (reminders == null)
            {
                reminders = new List<Reminder>();
            }

            _users[username] = new User()
            {
                Username = username,
                Email = email,
                PhoneNumber = phone,
                Password = password,
                Reminders = reminders
            };

            _currentUser = username;
        }

        public IList<Reminder> Display()
        {
            return _reminders;
        }

        public IDictionary<Category, IDictionary<Genre, IList<Reminder>>> GetRemindersMap()
        {
            return _remindersMap;
        }

        public User RetrieveUser(string name)
        {
            if (_users.TryGetValue(name, out var user))
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public void SendNotification()
        {
            var notifications = CheckTodayForReleases();
            foreach (var reminder in notifications.Keys)
            {
                var users = notifications[reminder];
                for (int i = 0; i < users.Count; i++)
                {
                    var user = users[i];
                    var email = new EmailMessage()
                    {
                        ToAddresses = new List<EmailAddress>() { new EmailAddress() { Name = user.Username, Address = user.Email } },
                        FromAddresses = new List<EmailAddress>() { new EmailAddress() { Name = "ReleaseReminder", Address = "releasereminder2018@gmail.com" } },
                        Subject = $"Reminder!! {reminder} was released today!",
                        Content = $"Hey {user.Username}, It's time to go!  This is you notification that {reminder} comes out today!  Enjoy!"
                    };
                    _emailService.Send(email);
                }
            }
        }

        private IDictionary<string, IList<User>> CheckTodayForReleases()
        {
            var date = DateTime.Now;
            List<Reminder> reminders = _reminders.Where(reminder => reminder.ReleaseDate.Date == date.Date).ToList();
            var notifications = new Dictionary<string, IList<User>>();
            for (int i = 0; i < reminders.Count; i++)
            {
                var reminder = reminders[i];
                if (_usersByTitle.TryGetValue(reminder.Title, out var users))
                {
                    notifications[reminder.Title] = users;
                }
            }

            return notifications;
        }
    }
}