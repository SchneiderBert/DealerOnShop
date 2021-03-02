using Microsoft.EntityFrameworkCore;

namespace DealerOnShop.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

    }
}