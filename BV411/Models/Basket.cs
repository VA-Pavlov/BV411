namespace BV411.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public double Price { get { return Products.Sum(i => i.Price); } }
        public int Count { get { return Products.Count; } }
        static int CountId = 0;
        public Basket() { CountId++; Id = CountId; }
    }
}
