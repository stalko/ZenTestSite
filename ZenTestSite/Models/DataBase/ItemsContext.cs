using Microsoft.EntityFrameworkCore;

namespace ZenTestSite.Models.DataBase
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<Items> Items { get; set; }

    }
}
