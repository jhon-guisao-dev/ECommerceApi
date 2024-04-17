namespace ECommerceApi.GraphQL.Types
{
    using ECommerceApi.GraphQL.Queries.CustomEntities;
    using ECommerceApi.GraphQL.Types.Orders;
    public class OrderDetailsAndTotalPriceType : ObjectType<OrderDetailsAndTotalPrice>
    {
        protected override void Configure(IObjectTypeDescriptor<OrderDetailsAndTotalPrice> descriptor)
        {
            descriptor.Field(t => t.OrderDetails)
                .Name("orderDetails")
                .Type<ListType<OrderDetailType>>()
                .Resolve(ctx => ctx.Parent<OrderDetailsAndTotalPrice>().OrderDetails);

            descriptor.Field(t => t.TotalPrice)
                .Name("totalPrice")
                .Type<DecimalType>()
                .Resolve(ctx => ctx.Parent<OrderDetailsAndTotalPrice>().TotalPrice);
        }
    }
}
