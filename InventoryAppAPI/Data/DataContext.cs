using Microsoft.EntityFrameworkCore;

namespace InventoryAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<UserInfo> Users { get; set; }

        public DbSet<ProductCategories> ProductCategories { get; set; }

        public DbSet<ProductInfo> Products { get; set; }

    }
}
