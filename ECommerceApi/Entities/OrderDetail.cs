namespace ECommerceApi.Data
{
    public class OrderDetail : BaseEntity
    {
        public OrderDetail()
        {
            Order = new Order();
            Product = new Product();
        }

        public int Quantity { get; set; }
        public decimal SubtotalPrice { get; set; }

        // Relations

        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
