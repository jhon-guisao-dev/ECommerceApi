namespace ECommerceApi.GraphQL.Services
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using ECommerceApi.GraphQL.Mutations.Inputs.Orders;
    using HotChocolate.AspNetCore;
    using Microsoft.EntityFrameworkCore;

    public class OrderServices : IOrderServices, IAsyncDisposable
    {
        private readonly DataContext _dbContext;

        public OrderServices(IDbContextFactory<DataContext> dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }

        public async Task<Order> CreateOrder(CreateOrderInput input)
        {
            var customer = await _dbContext.Customers.Where(x => x.Id == input.CustomerId).FirstOrDefaultAsync();

            if (customer == null)
            {
                throw new GraphQLRequestException($"Customer with id {input.CustomerId} not found");
            }

            var order = new Order
            {
                OrderDate = input.OrderDate,
                Customer = customer!,
            };

            foreach (var detailInput in input.OrderDetails)
            {
                var product = await _dbContext.Products.Where(x => x.Id == detailInput.ProductId).FirstOrDefaultAsync();

                if (product == null)
                {
                    throw new GraphQLRequestException($"Product with id {detailInput.ProductId} not found");
                }

                if (product.Stock < detailInput.Quantity)
                {
                    throw new GraphQLRequestException($"Insufficient stock of product {product.Name}");
                }

                var detail = new OrderDetail
                {
                    Quantity = detailInput.Quantity,
                    SubtotalPrice = detailInput.SubtotalPrice,
                    Product = product!
                };
                order.OrderDetails.Add(detail);

                product.Stock -= detailInput.Quantity;
            }

            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();

            return order;
        }

        public IQueryable<Order> GetOrders(long customerId)
        {
            return _dbContext.Orders
                .Where(x => x.CustomerId == customerId)
                .AsQueryable();
        }

        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }
    }
}
