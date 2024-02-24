// ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using ShoppingCartModels; // Assuming you've defined Product, Category, and ShoppingCart models

namespace ShoppingCartApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        // Other configurations, such as seeding data or relationships, can be added here
    }
}
