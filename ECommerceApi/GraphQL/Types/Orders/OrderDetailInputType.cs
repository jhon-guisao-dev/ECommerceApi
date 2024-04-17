namespace ECommerceApi.GraphQL.Types.Orders
{
    using ECommerceApi.GraphQL.Mutations.Inputs.Orders;
    public class OrderDetailInputType : InputObjectType<OrderDetailInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<OrderDetailInput> descriptor)
        {
            descriptor.Field(i => i.Quantity).Type<NonNullType<IntType>>();
            descriptor.Field(i => i.SubtotalPrice).Type<NonNullType<DecimalType>>();
            descriptor.Field(i => i.ProductId).Type<NonNullType<IdType>>();
        }
    }
}
