namespace ECommerceApi.GraphQL.Interfaces.Services
{
    using ECommerceApi.Data;

    public interface IProductCategoryServices
    {
        public IQueryable<ProductCategory> GetProductCategories(long productId);
    }
}
