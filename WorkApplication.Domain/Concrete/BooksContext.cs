using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using WorkApplication.Domain.Entities;

namespace WorkApplication.Models.Repository
{
    public class BooksContext : DbContext
    {
        //public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public BooksContext()
        {

        }

        //public BooksContext(DbContextOptions<BooksContext> options)
        //    : base(options)
        //{
        //    //Database.EnsureCreated();
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.BookId, x.AuthorId });
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server=.\\SQLEXPRESS;Database=WebBooks;Trusted_Connection=True;");
        //}
    }
}
