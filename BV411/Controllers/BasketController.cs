using BV411.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index(int Id)
        {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == Id);
            var basked = user.Basket;

            return View(basked);
        }
        public IActionResult Lover (int userId, int id)
        {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == userId);
            var basked = user.Basket;
            var basketProdukt = basked.Products
                .FirstOrDefault(pr => pr.Product.Id == id);
            if(basketProdukt != null)
            {
                basketProdukt.Count--;
            }
            if(basketProdukt.Count == 0)
            {
                basked.Products.Remove(basketProdukt);
            }
            return RedirectToAction("Index", new { Id = userId });
        }
        public IActionResult Upper(int userId, int id)
        {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == userId);
            var basked = user.Basket;
            var basketProdukt = basked.Products
                 .FirstOrDefault(pr => pr.Product.Id == id);
            if (basketProdukt != null)
            {
                basketProdukt.Count++;
            }
            return RedirectToAction("Index", new { Id = userId });
        }
        public IActionResult Delete(int userId, int number)
        {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == userId);
            var basked = user.Basket;
            basked.Products.RemoveAt(number);

            return RedirectToAction("Index", new { Id = userId });
        }
        public IActionResult Clear(int userId)
        {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == userId);
            var basked = user.Basket;
            basked.Products.Clear();

            return RedirectToAction("Index", new { Id = userId });
        }
    }
}
