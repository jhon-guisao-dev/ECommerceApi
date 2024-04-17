namespace ECommerceApi.GraphQL.Types
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Types.Orders;
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
            descriptor.Field(c => c.Name).Type<NonNullType<StringType>>();
            descriptor.Field(c => c.Address).Type<StringType>();
            descriptor.Field(c => c.Email).Type<NonNullType<StringType>>();
            descriptor.Field(c => c.Orders).Type<NonNullType<ListType<NonNullType<OrderType>>>>();
            descriptor.Ignore(t => t.IsDeleted);
            descriptor.Ignore(t => t.DeletedBy);
            descriptor.Ignore(t => t.CreationDate);
            descriptor.Ignore(t => t.UpdateDate);
            descriptor.Ignore(t => t.DeleteDate);
        }
    }
}
