namespace BV411.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public Basket Basket { get; set; }

        public List<Order> Orders { get; set; } = new();

        public Favorite Favorite { get; set; }
    }
}