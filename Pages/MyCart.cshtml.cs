using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BanhKemStore.MyTagHelper;
using BanhKemStore.Models;
using System.Linq;
namespace BanhKemStore.Pages
{
    public class MyCartModel : PageModel
    {
        private IBanhKemStoreRepository repository;
        public MyCartModel(IBanhKemStoreRepository repo, MyCart myCartService)
        {
            repository = repo;
            myCart = myCartService;
        }
        public MyCart myCart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long banhkemId, string returnUrl)
        {
            BanhKem banhkem = repository.BanhKems
            .FirstOrDefault(b => b.BanhKemID == banhkemId);
            myCart.AddItem(banhkem, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long banhkemId, string returnUrl)
        {
            myCart.RemoveLine(myCart.Lines.First(cl =>
            cl.BanhKem.BanhKemID == banhkemId).BanhKem);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}