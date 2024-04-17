namespace ECommerceApi.GraphQL.Mutations.Inputs.Orders
{
    public class OrderDetailInput
    {
        public int Quantity { get; set; }
        public decimal SubtotalPrice { get; set; }
        public long ProductId { get; set; }
    }
}
