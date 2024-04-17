namespace ECommerceApi.GraphQL.Interfaces.Services
{
    using ECommerceApi.Data;
    public interface IProductServices
    {
        public IQueryable<Product> GetProducts();
    }
}
