using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstCRDUDemo.Models
{
    public class FlipkartDbContext : DbContext
    {
        public FlipkartDbContext(DbContextOptions<FlipkartDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
