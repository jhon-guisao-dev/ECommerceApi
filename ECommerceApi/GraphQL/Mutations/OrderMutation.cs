
namespace ECommerceApi.GraphQL.Mutations
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using ECommerceApi.GraphQL.Mutations.Inputs.Orders;
    public class OrderMutations
    {
        public async Task<Order> CreateOrder(CreateOrderInput input, IOrderServices orderServices)
        {
            return await orderServices.CreateOrder(input);
        }
    }
}
