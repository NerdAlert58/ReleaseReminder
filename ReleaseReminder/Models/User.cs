using System;
using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public IList<DateTime> Reminders { get; set; }
    }
}