namespace ECommerceApi.Mutations
{
    public class ProductQuery
    {
        [GraphQLName("products")]
        public IEnumerable<String> GetProducts()
        {
            return new List<String>
            {
                "Product 1",
                "Product 2",
                "Product 3"
             };
        }
    }
}
