using BV411.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BV411.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            int userId = 1;

            var basket = _context.baskets
                .Include(x => x.BasketProducts)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.UserId == userId);

            return View(basket);
        }
        public IActionResult Add(int productId)
        {
            int userId = 1;

            var basket = _context.baskets
                .FirstOrDefault(x => x.UserId == userId);

            if (basket == null)
            {
                basket = new Basket { UserId = userId };
                _context.baskets.Add(basket);
                _context.SaveChanges();
            }

            var basketProduct = _context.BasketProducts
                .FirstOrDefault(x =>
                    x.BasketId == basket.Id &&
                    x.ProductId == productId);

            if (basketProduct == null)
            {
                _context.BasketProducts.Add(new BasketProduct
                {
                    BasketId = basket.Id,
                    ProductId = productId,
                    Quantity = 1
                });
            }
            else
            {
                basketProduct.Quantity++;
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Remove(int productId)
        {
            int userId = 1;

            var basket = _context.baskets
                .FirstOrDefault(x => x.UserId == userId);

            var item = _context.BasketProducts
                .FirstOrDefault(x =>
                    x.BasketId == basket.Id &&
                    x.ProductId == productId);

            if (item != null)
            {
                _context.BasketProducts.Remove(item);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
