using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorkApplication.Domain.Entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        
        public decimal Price { get; set; }
    }

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}