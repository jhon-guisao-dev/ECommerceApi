namespace ECommerceApi.GraphQL.Mutations.Inputs.Orders
{
    public class CreateOrderInput
    {
        public CreateOrderInput()
        {
            OrderDetails = new List<OrderDetailInput> { new OrderDetailInput() };   
        }
        public DateTime OrderDate { get; set; }
        public long CustomerId { get; set; }
        public List<OrderDetailInput> OrderDetails { get; set; }
    }
}
