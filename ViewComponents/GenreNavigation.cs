using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanhKemStore.Models;
namespace BanhKemStore.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private IBanhKemStoreRepository repository;
        public GenreNavigation(IBanhKemStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["genre"];
            return View(repository.BanhKems
            .Select(x => x.Genre)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}