using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class DanialsController : Controller
    {
        public IActionResult Index()
        {
            return View(DanyPepos.ProductList);
        }

        public IActionResult Info(int id)
        {
            Product Product = DanyPepos.ProductList.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }

        public IActionResult AddToBasket(int id, int idprod)
        {
            Product Product = DanyPepos.ProductList.FirstOrDefault(x => x.Id == idprod);
            var basket = BasketRepos.GetBasket(id);
            basket.AddProduct(Product);
            return RedirectToAction("Index");
        }
    }
}
