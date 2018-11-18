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
        Horror,
        Action,
        Adventure,
        Comedy,
        Drama,
        Country,
        Mystery,
        Suspence,
        Thriller,
        War,
        Crime,
        Animation,
        Family,
        Fantasy,
        Romance,
        Biography,
        Kids,
        Sport,
        Musical,
        History,
        Racing,
        Pop,
        Rap,
        FPS,
        MMORPG,
        RPG,
        Fighting,
        ABC,
        NBC,
        FOX,
        YoungAdult,
        Political,
        ScienceFiction
    }
}