using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WorkApplication.Domain.Entities;

namespace WorkApplication.Models.Repository
{
    public class EFDbContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}