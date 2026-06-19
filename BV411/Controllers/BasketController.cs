using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index(int basketId)
        {
            var basket = BasketRepos.GetBasket(basketId);
            return View(basket);
        }
        public IActionResult Add(int basketId, int id)
        {
            var basket = BasketRepos.GetBasket(basketId);

            Product product = ProductsRepos.product
                .FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                basket.Products.Add(product);
            }

            return RedirectToAction("Index", "Product");
        }
        public IActionResult Remove(int basketId, int id)
        {
            var basket = BasketRepos.GetBasket(basketId);

            Product product = basket.Products
                .FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                basket.Products.Remove(product);
            }

            return RedirectToAction("Index", new { basketId });
        }
        public IActionResult Clear(int basketId)
        {
            var basket = BasketRepos.GetBasket(basketId);

            if (basket != null)
            {
                basket.Products.Clear();
            }

            return RedirectToAction("Index", new { basketId });
        }
    }
}
