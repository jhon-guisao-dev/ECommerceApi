namespace ECommerceApi.GraphQL.Queries
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;

    [ExtendObjectType("Query")]
    public class ProductQueries
    {
        [UsePaging]
        public  IQueryable<Product> GetProducts(IProductServices productServices)
        {
            return  productServices.GetProducts();
        }
    }
}
