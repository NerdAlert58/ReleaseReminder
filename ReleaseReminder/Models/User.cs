using System;
using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IList<Reminder> Reminders { get; set; }
    }
}