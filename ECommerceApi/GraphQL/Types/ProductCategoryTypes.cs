using ECommerceApi.Data;

namespace ECommerceApi.GraphQL.Types
{
    public class ProductCategoryType : ObjectType<ProductCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<ProductCategory> descriptor)
        {
            descriptor.Field(t => t.Id);
            descriptor.Field(t => t.Name);
            descriptor.Field(t => t.Description);
            descriptor.Ignore(t => t.IsDeleted);
            descriptor.Ignore(t => t.DeletedBy);
            descriptor.Ignore(t => t.CreationDate);
            descriptor.Ignore(t => t.UpdateDate);
            descriptor.Ignore(t => t.DeleteDate);
            descriptor.Ignore(t => t.Products);
        }
    }
}
