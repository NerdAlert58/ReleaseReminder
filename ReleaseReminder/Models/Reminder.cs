using System;
using System.Collections;
using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public class Reminder : IComparer
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public IList<Genre> Genres { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int Compare(object x, object y)
        {
            var first = (Reminder)x;
            var second = (Reminder)y;
            return string.Compare(first.Title, second.Title);
        }

        public override bool Equals(object obj)
        {
            var other = (Reminder)obj;
            return string.Equals(this.Title, other.Title);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + this.Title.GetHashCode();
                return hash;
            }
        }
    }

    public enum Category
    {
        Movies,
        Music,
        VideoGames,
        Television,
        Books
    }

    public enum Genre
    {
        ABC,
        Action,
        Adventure,
        Animation,
        Biography,
        Comedy,
        Country,
        Crime,
        Drama,
        Family,
        Fantasy,
        Fighting,
        FOX,
        FPS,
        History,
        Horror,
        Kids,
        MMORPG,
        Musical,
        Mystery,
        NBC,
        Political,
        Pop,
        Racing,
        Rap,
        Reality,
        Romance,
        RPG,
        ScienceFiction,
        Sport,
        SuperHero,
        Suspence,
        Teen,
        Thriller,
        War,
        YoungAdult
    }
}