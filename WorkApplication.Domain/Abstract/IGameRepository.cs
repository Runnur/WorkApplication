using System.Collections.Generic;
using WorkApplication.Domain.Entities;

namespace WorkApplication.Domain.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
        IEnumerable<Category> Categories { get; }
    }
}
