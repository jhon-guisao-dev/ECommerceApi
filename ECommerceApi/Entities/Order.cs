namespace ECommerceApi.Data
{
    public class Order : BaseEntity
    {
        public Order()
        {
            Customer = new Customer();
            OrderDetails = new List<OrderDetail>();
        }
        public DateTime OrderDate { get; set; }

        // Relations

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
