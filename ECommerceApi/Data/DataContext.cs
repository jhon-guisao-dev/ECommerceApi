namespace ECommerceApi.Data
{
    using ECommerceApi.Data.DataSeeds;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductCategorySeed.Seed(modelBuilder);
            CustomerSeed.Seed(modelBuilder);

        }
    }
}
