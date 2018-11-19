using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ReleaseReminder.Models
{
    public class ReminderProvider : IReminderProvider
    {
        private string _filePath = "reminders.json";
        private IList<Reminder> _reminders = null;
        private IDictionary<Category, IDictionary<Genre, IList<Reminder>>> _remindersMap = null;

        public ReminderProvider()
        {
            _reminders = ReadFile(_filePath) ?? throw new ArgumentNullException(nameof(_reminders));
            _reminders = _reminders.OrderBy(o => o.ReleaseDate).ToList();
            _remindersMap = BuildMap() ?? throw new ArgumentNullException(nameof(_remindersMap));
        }

        public IList<Reminder> Reminders()
        {
            return _reminders;
        }
        public IDictionary<Category, IDictionary<Genre, IList<Reminder>>> RemindersMap()
        {
            return _remindersMap;
        }

        private IDictionary<Category, IDictionary<Genre, IList<Reminder>>> BuildMap()
        {
            var reminderMap = new Dictionary<Category, IDictionary<Genre, IList<Reminder>>>();
            for (int i = 0; i < _reminders.Count; i++)
            {
                var reminder = _reminders[i];
                if (!reminderMap.TryGetValue(reminder.Category, out var genreMap))
                {
                    genreMap = new Dictionary<Genre, IList<Reminder>>();
                }

                if (reminder.Genres == null || reminder.Genres.Count <= 0) continue;
                for (int j = 0; j < reminder.Genres.Count; j++)
                {
                    var genre = reminder.Genres[j];
                    if (!genreMap.TryGetValue(genre, out var reminderList))
                    {
                        reminderList = new List<Reminder>() { reminder };
                        continue;
                    }

                    if (reminderList.Contains(reminder))
                    {
                        System.Console.WriteLine($"{reminder.Title} was already in the list!!");
                    }
                    else
                    {
                        reminderList.Add(reminder);
                    }
                }
            }
            return reminderMap;
        }

        private IList<Reminder> ReadFile(string path)
        {
            var contents = File.ReadAllText(path);
            var savedValues = JsonConvert.DeserializeObject<ReminderList>(contents);

            return savedValues.Reminders;
        }
    }

    public class ReminderList
    {
        public IList<Reminder> Reminders { get; set; }
    }
}