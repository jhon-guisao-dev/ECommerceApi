namespace ECommerceApi.GraphQL.Types.Orders
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using ECommerceApi.GraphQL.Queries.CustomEntities;
    using ECommerceApi.GraphQL.Types.Orders.Util;

    public class OrderType : ObjectType<Order>
    {
        protected override void Configure(IObjectTypeDescriptor<Order> descriptor)
        {
            descriptor.Field(o => o.Id);
            descriptor.Field(o => o.OrderDate);
            descriptor.Field(o => o.Customer)
                .Type<CustomerType>()
                .Resolve(async context =>
                {
                    var order = context.Parent<Order>();
                    var customerServices = context.Service<ICustomerServices>();
                    return await customerServices.GetCustomer(order.CustomerId);
                });
            descriptor.Field("orderDetailsAndTotalPrice")
                .Type<OrderDetailsAndTotalPriceType>()
                .Resolve(context =>
                {
                    var order = context.Parent<Order>();
                    var orderDetailServices = context.Service<IOrderDetailServices>();
                    var orderDetails = orderDetailServices.GetOrderDetails(order.Id);

                    var totalPrice = OrderUtil.CalculateTotalPrice(orderDetails);

                   return new OrderDetailsAndTotalPrice(orderDetails.ToArray(), totalPrice);
                });
            descriptor.Ignore(t => t.OrderDetails);
            descriptor.Ignore(t => t.IsDeleted);
            descriptor.Ignore(t => t.DeletedBy);
            descriptor.Ignore(t => t.CreationDate);
            descriptor.Ignore(t => t.UpdateDate);
            descriptor.Ignore(t => t.DeleteDate);
        }
    }
}
