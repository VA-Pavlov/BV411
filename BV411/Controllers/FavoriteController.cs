using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Index()
        {
            return View(FavoriteRepos.GetFavorite());
        }

        public IActionResult Toggle(int id)
        {
            var favorite = FavoriteRepos.GetFavorite();

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