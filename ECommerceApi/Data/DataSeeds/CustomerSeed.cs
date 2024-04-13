namespace ECommerceApi.Data.DataSeeds
{
    using Microsoft.EntityFrameworkCore;
    public static class CustomerSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer 
                {
                    Id = 1,
                    Name = "Alex Smith",
                    Address = "Oak St, Los Angeles, CA 90403",
                    Email = "alex.smith@example.com",
                    IsDeleted = false,
                    CreationDate = DateTimeOffset.UtcNow,
                    UpdateDate = DateTimeOffset.UtcNow,
                    DeleteDate = DateTimeOffset.MinValue,
                }
            );
        }
    }
}
