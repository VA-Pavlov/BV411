namespace BV411.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal Price => Products.Sum(x => x.Price);
        public int Count => Products.Count;
        static int CountId = 0;
        public Basket() { CountId++; Id = CountId; }
    }
}
