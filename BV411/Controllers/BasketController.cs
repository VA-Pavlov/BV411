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
        public IActionResult Lover (int basketId, int id)
        {
            var basked = BasketRepos.GetBasket(basketId);
            var basketProdukt = basked.Products
                .FirstOrDefault(pr => pr.Product.Id == id);
            if(basketProdukt != null)
            {
                basketProdukt.Count--;
            }

            return RedirectToAction("Index", new { basketId = basketId });
        }
        public IActionResult Upper(int basketId, int id)
        {
            var basked = BasketRepos.GetBasket(basketId);
            var basketProdukt = basked.Products
                 .FirstOrDefault(pr => pr.Product.Id == basketId);
            if (basketProdukt != null)
            {
                basketProdukt.Count++;
            }
            return RedirectToAction("Index", new { basketId = basketId });
        }
        public IActionResult Delete(int basketId,int number)
        {
            var basked = BasketRepos.GetBasket(basketId);
            basked.Products.RemoveAt(number);

            return RedirectToAction("Index", new { basketId = basketId });
        }
        public IActionResult Clear(int basketId)
        {
            var basked = BasketRepos.GetBasket(basketId);
            basked.Products.Clear();

            return RedirectToAction("Index", new { basketId = basketId });
        }
    }
}
