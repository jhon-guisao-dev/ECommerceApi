namespace ECommerceApi.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    public class DbInitializer
    {
        private static Random random = new Random();
        public async Task  Initialize(DataContext context)
        {

            if (context.Products.Any())
            {
                return; 
            }

            var categories = await context.ProductCategories.ToListAsync();
            var productList = new List<Product>();
            foreach (var category in categories)
            {
                for (int j = 0; j < 20; j++)
                {
                    var categoryList = GetCategoryList(category, categories);
                    var product = new Product
                    {
                        Name = $"Product {j + 1} for category {category.Name}",
                        ImageUrl = categoryList[0].Name,
                        Description = $"Description for Product {j + 1}",
                        UnitPrice = GetRandomUnitPrice(),
                        Stock = GetRandomStock(),
                        ProductCategories = categoryList,
                        IsDeleted = false,
                        CreationDate = DateTimeOffset.UtcNow,
                        UpdateDate = DateTimeOffset.UtcNow,
                        DeleteDate = DateTimeOffset.MinValue,
                    };
                    productList.Add(product);
                }
            }

            context.Products.AddRange(productList);
            context.SaveChanges();
        }

        private  static List<ProductCategory> GetCategoryList(ProductCategory category, List<ProductCategory> categories)
        {
            var categoryList = new List<ProductCategory>()
            { 
                category
            };

            Random random = new Random();
            var categoryListIndex = random.Next(0, categories.Count());

            var categoryFiltered = categories[categoryListIndex];

            if (category.Id != categoryFiltered.Id && GetRandomBoolean())
            {
                categoryList.Add(categoryFiltered);
            }

            return categoryList;
        }

        private static bool GetRandomBoolean()
        {
            return random.Next(0, 2) == 0;
        }

        private static int GetRandomUnitPrice()
        {
            return random.Next(10, 101);
        }

        private static int GetRandomStock()
        {
            return random.Next(100, 301);
        }
    }
}
