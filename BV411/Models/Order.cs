namespace BV411.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int StatusId { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }

        public Status Status { get; set; }

        public List<OrderProduct> OrderProducts { get; set; } = new();
    }
}