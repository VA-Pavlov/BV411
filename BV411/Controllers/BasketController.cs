using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index(int basketId)
        {
            var basked = BasketRepos.GetBasket(basketId);

            return View(basked);
        }
    }
}
