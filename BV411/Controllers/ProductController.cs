using BV411.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BV411.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int userId = 1;

            ViewBag.FavoriteIds = _context.FavoriteProducts
                .Where(x => x.Favorite.UserId == userId)
                .Select(x => x.ProductId)
                .ToList();

            var products = _context.products.ToList();

            return View(products);
        }

        public IActionResult Info(int id)
        {
            var product = _context.products.FirstOrDefault(x => x.Id == id);

            int userId = 1;

            ViewBag.IsFavorite = _context.FavoriteProducts
                .Any(x => x.Favorite.UserId == userId &&
                          x.ProductId == id);

            return View(product);
        }
    }
}