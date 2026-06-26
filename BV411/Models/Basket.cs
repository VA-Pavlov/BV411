namespace BV411.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public List<Product> Products { get; set; } = new();

        public decimal Price => Products.Sum(x => x.Price);
        public int Count => Products.Count;
    }
}
