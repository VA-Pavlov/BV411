using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class DanialsController : Controller
    {
        public IActionResult Index() { return View(DanyPepos.DanikList);}
        public IActionResult Info(int id) {
            Danik danik = DanyPepos.DanikList.FirstOrDefault(x => x.Id == id);
            return View(danik);
        }
        public IActionResult AddToBasket(int idBasket, int idprod) {
            Danik danik = DanyPepos.DanikList.FirstOrDefault(x => x.Id == idprod);
            var basket = BasketRepos.GetBasket(idBasket);
            basket.Products.Add(danik);
            return RedirectToAction("Index");

        }
    }
}
