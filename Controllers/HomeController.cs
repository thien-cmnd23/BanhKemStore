using Microsoft.AspNetCore.Mvc;
using BanhKemStore.Models;
using System.Linq;
using BanhKemStore.Models.ViewModels;

namespace BanhKemStore.Controllers
{
    public class HomeController : Controller
    {
        private IBanhKemStoreRepository repository;
        public int PageSize = 3;
        public HomeController(IBanhKemStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(string genre, int bookPage = 1)
 => View(new BanhKemListViewModel
 {
     BanhKems = repository.BanhKems
 .Where(p => genre == null || p.Genre == genre)
 .OrderBy(p => p.BanhKemID)
 .Skip((bookPage - 1) * PageSize)
 .Take(PageSize),
     PagingInfo = new PagingInfo
     {
         CurrentPage = bookPage,
         ItemsPerPage = PageSize,
         TotalItems = genre == null ?
 repository.BanhKems.Count() :
 repository.BanhKems.Where(e =>
 e.Genre == genre).Count()
     },
     CurrentGenre = genre
 });

    }
}