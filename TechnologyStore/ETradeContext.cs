using System.Data.Entity;

namespace TechnologyStore
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
