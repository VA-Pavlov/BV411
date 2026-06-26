namespace BV411.Models.Entities {
    public class Order {
        public int Id { get; set; }
        public DateTime Date { get; }
        public string Status { get; set; }
        //public User
        List<Product> Products { get; set; }
    }
}