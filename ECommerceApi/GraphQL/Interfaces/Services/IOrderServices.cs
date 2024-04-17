namespace ECommerceApi.GraphQL.Interfaces.Services
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Mutations.Inputs.Orders;

    public interface IOrderServices
    {
        public Task<Order> CreateOrder(CreateOrderInput input);
        public IQueryable<Order> GetOrders(long customerId);
    }
}
