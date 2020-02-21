using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WorkApplication.Domain.Entities
{
    public class AbstractEntity
    {
        private int _id;
        public const string IdName = "Id";
        /// <summary>
        /// Идентификатор сущности (записи)
        /// </summary>
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }        
    }

    public class Song : AbstractEntity
    {
        private TimeSpan _duration = TimeSpan.Zero;

        public virtual string Title { get; set; }
        public virtual Genre GenreId { get; set; }
        public virtual Artist ArtistId { get; set; }
        public virtual string Url { get; set; }
        public virtual TimeSpan Duration { get; set; }
        public virtual int Order { get; set; }
        public virtual Album AlbumId { get; set; }
        public virtual int LyricsId { get; set; }
        public virtual int BitRate { get; set; }
    }


    public class Audio : AbstractEntity
    {

    }

    public class Album : AbstractEntity
    {
        public virtual string Title { get; set; }
    }
    public class Artist: AbstractEntity
    {
        /// <summary>
        /// Наименование (записи)
        /// </summary>
        public virtual string Name { get; set; }   
        public string Description { get; set; }
    }


    public class Genre : AbstractEntity
    {
        private List<Genre> _genres = new List<Genre>();

        public string Name { get; set; }
        public string RuName { get; set; }

        public IList<Genre> Genres
        {
            get {
                _genres.Add(new Genre { Id = 1, Name = "Rock", RuName = "Рок" });
                _genres.Add(new Genre { Id = 2, Name = "Pop", RuName = "Поп" });
                _genres.Add(new Genre { Id = 3, Name = "Rap & Hip-Hop", RuName = "Рэп & Хип-Хоп" });
                _genres.Add(new Genre { Id = 4, Name = "Easy Listening", RuName = "" });
                _genres.Add(new Genre { Id = 5, Name = "House & Dance", RuName = "" });
                _genres.Add(new Genre { Id = 6, Name = "Instrumental", RuName = "Инструментальная" });
                _genres.Add(new Genre { Id = 7, Name = "Metal", RuName = "Метал" });
                _genres.Add(new Genre { Id = 8, Name = "Dubstep", RuName = "" });
                _genres.Add(new Genre { Id = 9, Name = "Alternative", RuName = "Альтернатива" });
                _genres.Add(new Genre { Id = 10, Name = "Drum & Bass", RuName = "" });
                _genres.Add(new Genre { Id = 11, Name = "Trance", RuName = "Транс" });
                _genres.Add(new Genre { Id = 12, Name = "Chanson", RuName = "Шансон" });
                _genres.Add(new Genre { Id = 13, Name = "Ethnic", RuName = "Этническая" });
                _genres.Add(new Genre { Id = 14, Name = "Acoustic & Vocal", RuName = "" });
                _genres.Add(new Genre { Id = 15, Name = "Reggae", RuName = "Рэгги" });
                _genres.Add(new Genre { Id = 16, Name = "Classical", RuName = "Классическая" });
                _genres.Add(new Genre { Id = 17, Name = "Indie Pop", RuName = "Инди Поп" });
                _genres.Add(new Genre { Id = 18, Name = "Other", RuName = "Другая" });
                _genres.Add(new Genre { Id = 19, Name = "Speech", RuName = "" });
                _genres.Add(new Genre { Id = 20, Name = "Electropop & Disco", RuName = "" });
                _genres.Add(new Genre { Id = 21, Name = "Jazz & Blues", RuName = "Джаз & Блюз" });
                return _genres;
            }
        }
    }
}
