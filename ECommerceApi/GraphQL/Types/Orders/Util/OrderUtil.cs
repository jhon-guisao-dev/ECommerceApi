namespace ECommerceApi.GraphQL.Types.Orders.Util
{
    using ECommerceApi.Data;
    public static class OrderUtil
    {
        public static decimal CalculateTotalPrice(IEnumerable<OrderDetail> orderDetails)
        {
            decimal totalPrice = 0.0m;
            foreach (var detail in orderDetails)
            {
                totalPrice += detail.SubtotalPrice * detail.Quantity;
            }
            return totalPrice;
        }
    }
}
