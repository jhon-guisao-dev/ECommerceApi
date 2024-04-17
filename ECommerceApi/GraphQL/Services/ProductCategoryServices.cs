namespace ECommerceApi.GraphQL.Services
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using Microsoft.EntityFrameworkCore;

    public class ProductCategoryServices : IProductCategoryServices, IAsyncDisposable
    {
        private readonly DataContext _dbContext;

        public ProductCategoryServices(IDbContextFactory<DataContext> dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }

        public IQueryable<ProductCategory> GetProductCategories(long productId)
        {
            return  _dbContext.ProductCategories
                .Where(pc => pc.Products.Any(p => p.Id == productId))
                .AsQueryable();
        }

        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }

    }
}
