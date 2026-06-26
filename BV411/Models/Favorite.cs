namespace BV411.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        public List<Product> Products { get; set; } = new();

        public int Count => Products.Count;
    }
}