using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            int? userId =
                HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Auth", "Account");

            var orders =
                OrderRepos.GetByUser(userId.Value);

            return View(orders);
        }

        public IActionResult CreateFromBasket()
        {
            int? userId =
                HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Auth", "Account");

            var basket =
                BasketRepos.GetByUser(userId.Value);

            if (basket.Products.Count == 0)
                return RedirectToAction("Index", "Basket");

            var order =
                OrderRepos.CreateFromBasket(basket);

            BasketRepos.Clear(userId.Value);

            return RedirectToAction("Details",
                new { id = order.Id });
        }
        public IActionResult BuyNow(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Auth", "Account");

            var product = ProductsRepos.product
                .FirstOrDefault(x => x.Id == id);

            if (product == null)
                return RedirectToAction("Index", "Product");

            var basket = new Basket
            {
                UserId = userId.Value
            };

            basket.Products.Add(product);

            var order = OrderRepos.CreateFromBasket(basket);

            return RedirectToAction("Details", new { id = order.Id });
        }

        public IActionResult Details(int id)
        {
            var order = OrderRepos.GetById(id);

            if (order == null)
                return RedirectToAction("Index");

            return View(order);
        }

        public IActionResult ChangeStatus(int id, string status)
        {
            OrderRepos.ChangeStatus(id, status);

            return RedirectToAction("Details",
                new { id });
        }
    }
}