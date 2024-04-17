namespace ECommerceApi.GraphQL.Services
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using Microsoft.EntityFrameworkCore;
    public class OrderDetailServices : IOrderDetailServices, IAsyncDisposable
    {
        private readonly DataContext _dbContext;

        public OrderDetailServices(IDbContextFactory<DataContext> dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }
        public IQueryable<OrderDetail> GetOrderDetails(long orderId)
        {
            return _dbContext.OrderDetails
                .Where(x => x.OrderId == orderId)
                .AsQueryable();
        }

        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }
    }
}
