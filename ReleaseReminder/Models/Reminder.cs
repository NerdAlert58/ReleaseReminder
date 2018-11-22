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