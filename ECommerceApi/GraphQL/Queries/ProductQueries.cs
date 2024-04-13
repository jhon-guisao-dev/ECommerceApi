using ECommerceApi.Data;
using HotChocolate.Types;

namespace ECommerceApi.GraphQL.Queries
{
    public class ProductQueries
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProducts([Service] DataContext dbContext) =>
            dbContext.Products;
    }
}
