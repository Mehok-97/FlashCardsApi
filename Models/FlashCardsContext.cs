using Microsoft.EntityFrameworkCore;

namespace FlashCardsApi.Models
{
    public class FlashCardsContext : DbContext
    {
        public FlashCardsContext(DbContextOptions<FlashCardsContext> options):base(options)
        {
        }
        public DbSet<Product> Products { get; set; }=null!;
        public DbSet<Category> Categories { get; set; }=null!;
        public DbSet<Details> Details { get; set; }=null!;
    }
}