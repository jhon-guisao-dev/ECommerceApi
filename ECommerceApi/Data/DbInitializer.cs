using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ECommerceApi.Data
{
    public class DbInitializer
    {
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
                    var product = new Product
                    {
                        Name = $"Product {j + 1} for category {category.Name}",
                        ImageUrl = category.Name,
                        Description = $"Description for Product {j + 1}",
                        UnitPrice = GetRandomUnitPrice(),
                        Stock = GetRandomStock(),
                        ProductCategory = category,
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

        private static int GetRandomUnitPrice()
        {
            Random random = new Random();
            return random.Next(10, 101);
        }

        private static int GetRandomStock()
        {
            Random random = new Random();
            return random.Next(100, 301);
        }
    }
}
