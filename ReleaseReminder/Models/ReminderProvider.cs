using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ReleaseReminder.Models
{
    public class ReminderProvider
    {
        private string _filePath = null;
        private IList<Reminder> _reminders = null;

        public ReminderProvider(string path)
        {
            _filePath = path ?? throw new ArgumentNullException(nameof(_filePath));
            _reminders = ReadFile(_filePath) ?? throw new ArgumentNullException(nameof(_reminders));
        }

        public IList<Reminder> ReadFile(string path)
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