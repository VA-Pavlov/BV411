using System.ComponentModel.DataAnnotations.Schema;

namespace BV411.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<FavoriteProduct> FavoriteProducts { get; set; } = new();
        [NotMapped]
        public int Count => FavoriteProducts.Count;
    }
}