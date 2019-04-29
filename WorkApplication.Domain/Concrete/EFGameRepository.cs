using System;
using System.Collections.Generic;
using WorkApplication.Domain.Entities;
using WorkApplication.Domain.Abstract;
using WorkApplication.Models.Repository;

namespace WorkApplication.Domain.Concrete
{
    public class EFGameRepository: IGameRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }

        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}
