using Microsoft.EntityFrameworkCore;
namespace BanhKemStore.Models
{
    public class BanhKemStoreDbContext : DbContext
    {
        public BanhKemStoreDbContext(DbContextOptions<BanhKemStoreDbContext>
       options)
        : base(options) { }
        public DbSet<BanhKem> BanhKems { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
