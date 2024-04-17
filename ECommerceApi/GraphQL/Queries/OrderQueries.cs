namespace ECommerceApi.GraphQL.Queries
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;

    [ExtendObjectType("Query")]
    public class OrderQueries
    {
        [UsePaging]
        public IQueryable<Order> GetOrders(IOrderServices orderServices, long customerId)
        {
            return orderServices.GetOrders(customerId);
        }
    }
}
