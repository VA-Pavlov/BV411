using System.ComponentModel.DataAnnotations.Schema;
namespace BV411.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<BasketProduct> BasketProducts { get; set; } = new();

        [NotMapped]
        public decimal Price =>
            BasketProducts.Sum(x => x.Product.Price);

        [NotMapped]
        public int Count =>
            BasketProducts.Count;
    }
}