namespace ECommerceApi.GraphQL.Queries.CustomEntities
{
    using ECommerceApi.Data;
    public class OrderDetailsAndTotalPrice
    {
        public ICollection<OrderDetail> OrderDetails { get; }
        public decimal TotalPrice { get; }

        public OrderDetailsAndTotalPrice(ICollection<OrderDetail> orderDetails, decimal totalPrice)
        {
            OrderDetails = orderDetails;
            TotalPrice = totalPrice;
        }
    }
}
