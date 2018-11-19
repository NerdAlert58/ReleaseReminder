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

        public override bool Equals(object obj)
        {
            var other = (User)obj;
            return string.Equals(this.Username, other.Username);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + this.Username.GetHashCode();
                hash = hash * 23 + this.Email.GetHashCode();
                return hash;
            }
        }
    }
}