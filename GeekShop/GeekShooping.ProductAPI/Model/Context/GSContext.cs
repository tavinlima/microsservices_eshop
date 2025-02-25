using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Model.Context
{
    public class GSContext : DbContext
    {
        public GSContext() { }
        public GSContext(DbContextOptions<GSContext> options) : base(options){ }
        
        public DbSet<Product> Products { get; set; }
    }
}
