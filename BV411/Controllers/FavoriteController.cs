using BV411.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BV411.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly AppDbContext _context;

        public FavoriteController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int userId = 1;

            var favorite = _context.Favorites
                .Include(x => x.FavoriteProducts)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.UserId == userId);

            return View(favorite);
        }

        public IActionResult Toggle(int id)
        {
            int userId = 1;

            var favorite = _context.Favorites
                .Include(x => x.FavoriteProducts)
                .FirstOrDefault(x => x.UserId == userId);

            if (favorite == null)
                return RedirectToAction("Index");

            var favoriteProduct = _context.FavoriteProducts
                .FirstOrDefault(x =>
                    x.FavoriteId == favorite.Id &&
                    x.ProductId == id);

            if (favoriteProduct == null)
            {
                _context.FavoriteProducts.Add(new FavoriteProduct
                {
                    FavoriteId = favorite.Id,
                    ProductId = id
                });
            }
            else
            {
                _context.FavoriteProducts.Remove(favoriteProduct);
            }

            _context.SaveChanges();

            var referer = Request.Headers["Referer"].ToString();

            if (!string.IsNullOrEmpty(referer))
                return Redirect(referer);

            return RedirectToAction("Index");
        }
    }
}