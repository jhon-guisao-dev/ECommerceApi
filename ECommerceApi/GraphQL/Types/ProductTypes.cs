namespace ECommerceApi.GraphQL.Types
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;

    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Field(t => t.Id);
            descriptor.Field(t => t.Name);
            descriptor.Field(t => t.ImageUrl);
            descriptor.Field(t => t.Description);
            descriptor.Field(t => t.UnitPrice);
            descriptor.Field(t => t.Stock);
            descriptor.Ignore(t => t.IsDeleted);
            descriptor.Ignore(t => t.DeletedBy);
            descriptor.Ignore(t => t.CreationDate);
            descriptor.Ignore(t => t.UpdateDate);
            descriptor.Ignore(t => t.DeleteDate);
            descriptor.Field(t => t.ProductCategories)
                     .Type<ListType<ProductCategoryType>>()
                     .Resolve(context =>
                     {
                         var product = context.Parent<Product>();
                         var productCategoryServices = context.Service<IProductCategoryServices>();
                         return productCategoryServices.GetProductCategories(product.Id);
                     });
        }
    }
}
