namespace BV411.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<Basket> Baskets { get; set; } = new();
    }
}