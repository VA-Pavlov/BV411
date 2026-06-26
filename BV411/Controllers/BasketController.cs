using BV411.Models.rip;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult index(int id)
        {
            return View(UserRip.ActivUser.Basket);
        }
        public IActionResult delete(int id, int ip) {
            BasketRip.GetBasket(id).deleteProd(ip);
            return RedirectToAction("Index", id);
        }
        public IActionResult clear(int id)
        {
            BasketRip.GetBasket(id).Products.Clear();
            return RedirectToAction("Index", id);
        }
    }
}
