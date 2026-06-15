using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductsRepos.product);
        }

        public IActionResult Info(int id)
        {
            Product product = ProductsRepos.product.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}