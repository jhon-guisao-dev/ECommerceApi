namespace ECommerceApi.GraphQL.Interfaces.Services
{
    using ECommerceApi.Data;
    public interface ICustomerServices
    {
        public Task<Customer> GetCustomer(long customerId);
    }
}
