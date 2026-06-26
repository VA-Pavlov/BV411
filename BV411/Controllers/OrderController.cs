using Microsoft.AspNetCore.Mvc;
using BV411.Models;

namespace BV411.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index", "Account");

            var orders = OrderRepos.GetByUser(userId.Value);

            return View(orders);
        }

        public IActionResult CreateFromBasket()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index", "Account");

            var basket = BasketRepos.GetByUser(userId.Value);

            var order = OrderRepos.CreateFromBasket(basket);

            BasketRepos.Clear(userId.Value);

            return RedirectToAction("Details", new { id = order.Id });
        }

        public IActionResult Details(int id)
        {
            var order = OrderRepos.GetById(id);
            return View(order);
        }

        public IActionResult ChangeStatus(int id, string status)
        {
            OrderRepos.ChangeStatus(id, status);
            return RedirectToAction("Details", new { id });
        }
    }
}