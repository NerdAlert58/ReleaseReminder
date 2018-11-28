using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public interface IReminderProvider
    {
        IList<Reminder> Reminders();
        IDictionary<Category, IDictionary<Genre, IList<Reminder>>> RemindersMap();
        IDictionary<string, Reminder> RemindersByTitle();
    }
}