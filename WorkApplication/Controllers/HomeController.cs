using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkApplication.Models;
using WorkApplication.Domain.Abstract;
using WorkApplication.Models.Repository;

namespace WorkApplication.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext db = new EFDbContext();
        private IGameRepository repository;
        public int pageSize = 3;

        public HomeController(IGameRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int page = 1)
        {
            repository.Categories.ToList();
            GamesListViewModel model = new GamesListViewModel
            {
                Games = repository.Games.Where(p => category == null || p.Category.Name == category).OrderBy(game => game.GameId).Skip((page - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ? repository.Games.Count() : repository.Games.Where(game => game.Category.Name == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
        public ActionResult Index()
        {
            System.IO.DirectoryInfo dd = new System.IO.DirectoryInfo("C:/");
            var f = dd.GetFiles().ToList<System.IO.FileInfo>();
            var d = dd.GetDirectories().ToList<System.IO.DirectoryInfo>();
            ViewData["Files"] = f;
            ViewData["Dirs"] = d;
            var ddd = db.Categories.ToList();
            var gam = db.Games.ToList();
            var cat = repository.Categories.ToList();
            return View(repository.Games);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Edit()
        {
            return View("");
        }
    }
}