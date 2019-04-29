using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkApplication.Domain.Abstract;

namespace WorkApplication.Controllers
{
    public class NavController : Controller
    {
        private IGameRepository repository;

        public NavController(IGameRepository repo)
        {
            repository = repo;
        }
        // GET: Nav
        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = repository.Categories.Select(cat => cat.Name).OrderBy(x => x);
            return PartialView(categories);
        }
    }
}