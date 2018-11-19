using System;
using System.Collections.Generic;
using System.Linq;
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
        private IEmailService _emailService = null;
        public ReminderService(IReminderProvider reminderProvider, IEmailService emailService)
        {
            _reminderProvider = reminderProvider ?? throw new System.ArgumentNullException(nameof(reminderProvider));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _users = new Dictionary<string, User>();
            _usersByTitle = new Dictionary<string, IList<User>>();
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
                    if (!_usersByTitle.TryGetValue(reminder.Title, out var users))
                    {
                        users = new List<User>();
                    }
                    if (!users.Contains(user))
                    {
                        users.Add(user);
                    }
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

        public IList<Reminder> Display()
        {
            return _reminders;
        }

        public IDictionary<Category, IDictionary<Genre, IList<Reminder>>> GetRemindersMap()
        {
            return _remindersMap;
        }

        public void InsertUser(User user)
        {
            // Verify User fields exist and aren't empty

            // Verify that the user isn't already in the set

            // Add the User to the set
            throw new System.NotImplementedException();
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
                        FromAddresses = new List<EmailAddress>() { new EmailAddress() { Name = "ReleaseReminder", Address = "releasereminder2018.com" } },
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