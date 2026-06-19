using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index(int basketId) {
            var basked = BasketRepos.GetBasket(basketId);
            return View(basked);
        }
        public IActionResult Delete(int Basketid, int number) {
            var basked = BasketRepos.GetBasket(Basketid);
            basked.Products.RemoveAt(number);
            return RedirectToAction("Index", new { basked = Basketid });

        }
        public IActionResult Clear(int Basketid) {
            var basked = BasketRepos.GetBasket(Basketid);
            basked.Products.Clear();
            return RedirectToAction("Index",new {basked=Basketid});
        }
    }
}
