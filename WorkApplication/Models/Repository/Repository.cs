using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkApplication.Domain.Entities;

namespace WorkApplication.Models.Repository
{   
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
    }
}