using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index(int basketId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Auth", "Account");
            }
            var basket = BasketRepos.GetByUser(userId.Value);
            return View(basket);
        }

        public IActionResult Add(int basketId, int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Auth", "Account");
            }
            var basket = BasketRepos.GetByUser(userId.Value);

            var product = ProductsRepos.product
                .FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                basket.Products.Add(product);
            }

            var referer = Request.Headers["Referer"].ToString();

            if (!string.IsNullOrEmpty(referer))
                return Redirect(referer);

            return RedirectToAction("Index", "Product");
        }
        public IActionResult Remove(int basketId, int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Auth", "Account");
            }
            var basket = BasketRepos.GetByUser(userId.Value);

            basket.Products.RemoveAll(x => x.Id == id);

            return RedirectToAction("Index", new { basketId });
        }
        public IActionResult Minus(int basketId, int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Auth", "Account");
            }
            var basket = BasketRepos.GetByUser(userId.Value);

            var product = basket.Products
                .FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                basket.Products.Remove(product);
            }

            return RedirectToAction("Index", new { basketId });
        }
        public IActionResult Clear()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Auth", "Account");

            BasketRepos.Clear(userId.Value);

            return RedirectToAction("Index");
        }
    }
}
