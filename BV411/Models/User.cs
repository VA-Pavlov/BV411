namespace BV411.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string Login { get; set; }
        public required string Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Avatar { get; set; }
        public Basket Basket { get; set; }

        public Favorite Favorite { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}