using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net.NetworkInformation;

namespace BV411.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Basket> baskets { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasketProduct>()
                .HasKey(x => new { x.BasketId, x.ProductId });

            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.OrderId, x.ProductId });

            modelBuilder.Entity<FavoriteProduct>()
                .HasKey(x => new { x.FavoriteId, x.ProductId });

            modelBuilder.Entity<BasketProduct>()
                .HasKey(x => new { x.BasketId, x.ProductId });

            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.OrderId, x.ProductId });
            modelBuilder.Entity<Basket>()
                .HasIndex(x => x.UserId)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}