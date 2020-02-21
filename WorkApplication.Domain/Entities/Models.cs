using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkApplication.Domain.Entities
{
    public class Models
    {
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime? DatePublish { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public Language Language { get; set; }
        public virtual IList<Category> Category { get; set; }
        public byte[] Image { get; set; }
        public string ImageUrl { get; set; }
        // Ссылка на заказы
        public virtual IList<Order> Orders { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<BookAuthor> AuthorsLink { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }

    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }

    [Table("Category")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //public IList<Book> Books { get; set; }
        public int? ParentId { get; set; }
        public int OrderNumber { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public IList<Book> Books { get; set; }
    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }

    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }

    public class Review
    {
        public int ReviewId { get; set; }
        public string VoterName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }
        public int BookId { get; set; }
    }
}
