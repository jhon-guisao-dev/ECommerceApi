namespace ECommerceApi.Data.DataSeeds
{
    using Microsoft.EntityFrameworkCore;
    using System;

    public static class ProductCategorySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    Id = 1,
                    Name = "Sport Shoes",
                    Description = "Shoes for various sports activities",
                    IsDeleted = false,
                    CreationDate = DateTimeOffset.UtcNow,
                    UpdateDate = DateTimeOffset.UtcNow,
                    DeleteDate = DateTimeOffset.MinValue, 
                },
                new ProductCategory
                {
                    Id = 2,
                    Name = "Sport Shirt",
                    Description = "Shirts for sports enthusiasts",
                    IsDeleted = false,
                    CreationDate = DateTimeOffset.UtcNow,
                    UpdateDate = DateTimeOffset.UtcNow,
                    DeleteDate = DateTimeOffset.MinValue,
                },
                new ProductCategory
                {
                    Id = 3,
                    Name = "Sport Pants",
                    Description = "Pants suitable for sports",
                    IsDeleted = false,
                    CreationDate = DateTimeOffset.UtcNow,
                    UpdateDate = DateTimeOffset.UtcNow,
                    DeleteDate = DateTimeOffset.MinValue,
                },
                new ProductCategory
                {
                    Id = 4,
                    Name = "Sport Accessories",
                    Description = "Accessories for sports",
                    IsDeleted = false,
                    CreationDate = DateTimeOffset.UtcNow,
                    UpdateDate = DateTimeOffset.UtcNow,
                    DeleteDate = DateTimeOffset.MinValue,
                }
            );
        }
    }
}

