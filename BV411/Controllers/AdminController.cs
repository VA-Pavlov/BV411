using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class AdminController : Controller
    {
        private bool IsAdmin()
        {
            int? id = HttpContext.Session.GetInt32("UserId");

            if (id == null)
                return false;

            var user = UserRepos.Get(id.Value);

            return user != null && user.IsAdmin;
        }

        public IActionResult Index()
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            return View();
        }

        public IActionResult Products()
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            return View(ProductsRepos.product);
        }

        public IActionResult Orders()
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            return View(OrderRepos.GetAll());
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            return View(new Product());
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            ProductsRepos.Add(product);

            return RedirectToAction(nameof(Products));
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            return View(ProductsRepos.Get(id));
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            ProductsRepos.Update(product);

            return RedirectToAction(nameof(Products));
        }

        public IActionResult DeleteProduct(int id)
        {
            if (!IsAdmin())
                return RedirectToAction("Index", "Product");

            ProductsRepos.Delete(id);

            return RedirectToAction(nameof(Products));
        }

    }
}
