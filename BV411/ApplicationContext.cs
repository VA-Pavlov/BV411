using Microsoft.EntityFrameworkCore;

namespace BV411
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MyAppDb;Trusted_Connection=True;");
        }
    }

}
