namespace BV411.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public List<OrderItem> Items { get; set; } = new();

        public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);

        public string Status { get; set; } = "Создан";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}