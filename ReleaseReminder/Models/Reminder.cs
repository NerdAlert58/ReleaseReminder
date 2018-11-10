using System;
using System.Collections.Generic;

namespace ReleaseReminder.Models
{
    public class Reminder
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public IList<Genre> Genres { get; set; }
        public DateTime ReleaseDate { get; set; }
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
        Country,
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