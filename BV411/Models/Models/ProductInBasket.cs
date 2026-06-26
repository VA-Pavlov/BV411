using BV411.Models.Entities;

namespace BV411.Models.Models
{
    public class ProductInBasket
    {
        public ProductInBasket(Product product) {
            Product = product;
            Count = 1;
        }
        public Product Product { get; set; }
        public int Count { get; set; }
        public double Price { get { return Product.Prise * Count; } }
    }
}
