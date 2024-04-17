namespace ECommerceApi.GraphQL.Types.Orders
{
    using ECommerceApi.Data;
    public class OrderDetailType : ObjectType<OrderDetail>
    {
        protected override void Configure(IObjectTypeDescriptor<OrderDetail> descriptor)
        {
            descriptor.Field(od => od.Id);
            descriptor.Field(od => od.Quantity);
            descriptor.Field(od => od.SubtotalPrice);
            descriptor.Ignore(t => t.IsDeleted);
            descriptor.Ignore(t => t.DeletedBy);
            descriptor.Ignore(t => t.CreationDate);
            descriptor.Ignore(t => t.UpdateDate);
            descriptor.Ignore(t => t.DeleteDate);
        }
    }
}
