using BV411.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult index(int id)
        {
            return View(BasketRip.GetBasket(id));
        }
    }
}
