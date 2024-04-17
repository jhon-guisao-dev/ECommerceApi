namespace ECommerceApi.GraphQL.Resolvers
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using Microsoft.EntityFrameworkCore;

    public  class ProductServices : IProductServices, IAsyncDisposable
    {
        private readonly DataContext _dbContext;
        public ProductServices(IDbContextFactory<DataContext> dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }
        public  IQueryable<Product> GetProducts()
        {
            return  _dbContext.Products.AsQueryable();
        }

        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }
    }
}
