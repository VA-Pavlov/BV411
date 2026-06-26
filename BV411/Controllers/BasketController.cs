using BV411.Models.Entities;
using BV411.Models.Repository;
using Microsoft.AspNetCore.Mvc;
namespace BV411.Controllers {
    public class BasketController : Controller {
        public IActionResult Index(int Id) {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == Id);
            var basked = user.Basket; return View(basked);
        }
        public IActionResult Lover(int UserId,int Id) {
            var user= UsersRepos.Users.FirstOrDefault(user => user.Id == UserId);
            var basked = user.Basket;
            var basketProduct=basked.Products.FirstOrDefault(pr=>pr.Product.Id==Id);
            if (basketProduct != null) { basketProduct.Count--; }
            if (basketProduct.Count==0) { basked.Products.Remove(basketProduct);}
            return RedirectToAction("Index", new { basketId = UserId }); 
         }
        public IActionResult Delete(int UserId, int number) {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == UserId);
            var basked = user.Basket; basked.Products.RemoveAt(number);
            return RedirectToAction("Index", new { Id = UserId });
        }
        public IActionResult Upper(int UserId, int Id) {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == UserId);
            var basked = user.Basket;
            var basketProduct = basked.Products.FirstOrDefault(pr => pr.Product.Id == Id);
            if (basketProduct != null) { basketProduct.Count++; }
            return RedirectToAction("Index", new {Id = UserId });
        }
        public IActionResult Clear(int UserId) {
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == UserId);
            var basked = user.Basket; basked.Products.Clear();
            return RedirectToAction("Index", new { Id = UserId });
        }
    }
}