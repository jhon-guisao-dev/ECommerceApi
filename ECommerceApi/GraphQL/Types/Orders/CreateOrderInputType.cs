namespace ECommerceApi.GraphQL.Types.Orders
{
    using ECommerceApi.GraphQL.Mutations.Inputs.Orders;
    public class CreateOrderInputType : InputObjectType<CreateOrderInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<CreateOrderInput> descriptor)
        {
            descriptor.Field(i => i.OrderDate).Type<NonNullType<DateTimeType>>();
            descriptor.Field(i => i.CustomerId).Type<NonNullType<LongType>>();
            descriptor.Field(i => i.OrderDetails).Type<NonNullType<ListType<NonNullType<OrderDetailInputType>>>>();
        }
    }
}
