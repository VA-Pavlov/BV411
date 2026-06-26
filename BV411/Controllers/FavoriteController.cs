using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var favorite = FavoriteRepos.GetFavorite(userId.Value);

            return View(favorite);
        }

        public IActionResult Toggle(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var favorite = FavoriteRepos.GetFavorite(userId.Value);

            var product = favorite.Products
                .FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                product = ProductsRepos.product
                    .FirstOrDefault(x => x.Id == id);

                if (product != null)
                {
                    favorite.Products.Add(product);
                }
            }
            else
            {
                favorite.Products.Remove(product);
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}