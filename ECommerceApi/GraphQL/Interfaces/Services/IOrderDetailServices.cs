namespace ECommerceApi.GraphQL.Interfaces.Services
{
    using ECommerceApi.Data;
    public interface IOrderDetailServices
    {
        public IQueryable<OrderDetail> GetOrderDetails(long orderId);
    }
}
