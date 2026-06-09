namespace BV411.Models
{
    public class Product
    {
        public Product(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"id: {Id} | title: {Title} | price: {Price}";
        }
    }
}
