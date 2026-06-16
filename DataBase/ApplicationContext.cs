using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<orders> Orders { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<Users> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
