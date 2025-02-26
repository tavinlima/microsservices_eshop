using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Model.Context
{
    public class GSContext : DbContext
    {
        public GSContext() { }
        public GSContext(DbContextOptions<GSContext> options) : base(options){ }
        
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Para criar o banco de dados já populado com dados
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curso de desenvolvimento Web II",
                Price = 29.9m,
                Description = "Curso para aperfeiçoamento do desenvolvimento de aplicações Web, com HTML, CSS e Javascript",
                CategoryName = "Educação",
                ImageURL = "https://github.com/tavinlima/SPODWE1/blob/main/src/img/meta_img.png?raw=true"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Curso de desenvolvimento Web III",
                Price = 59.9m,
                Description = "Curso para aperfeiçoamento do desenvolvimento de aplicações Web, com HTML, CSS e Javascript",
                CategoryName = "Educação",
                ImageURL = "https://github.com/tavinlima/SPODWE1/blob/main/src/img/meta_img.png?raw=true"
            });
        }
    }
}
