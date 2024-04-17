namespace ECommerceApi.GraphQL.Services
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using Microsoft.EntityFrameworkCore;

    public class CustomerServices : ICustomerServices, IAsyncDisposable
    {
        private readonly DataContext _dbContext;

        public CustomerServices(IDbContextFactory<DataContext> dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }

        public async Task<Customer> GetCustomer(long customerId)
        {
            var customer = await _dbContext.Customers
                .Where(x => x.Id == customerId)
                .FirstOrDefaultAsync();
            return customer;
        }

        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }
    }
}
