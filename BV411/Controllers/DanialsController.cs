using BV411.Models.Entities;
using BV411.Models.Repository;
using Microsoft.AspNetCore.Mvc;
namespace BV411.Controllers {
    public class DanialsController : Controller {
        public IActionResult Index() { return View(DanyPepos.DanikList); }
        public IActionResult Info(int id) {
            Product danik = DanyPepos.DanikList.FirstOrDefault(x => x.Id == id);
            return View(danik);
        }
        public IActionResult AddToBasket(int UserId, int idprod) {
            Product danik = DanyPepos.DanikList.FirstOrDefault(x => x.Id == idprod);
            var user = UsersRepos.Users.FirstOrDefault(user => user.Id == UserId);
            var basked = user.Basket;
            basked.AddProduct(new Models.Models.ProductInBasket(danik));
            return RedirectToAction("Index");
        }
    }
}