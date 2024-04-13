using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Data
{
    public class OrderDetail : BaseEntity
    {
        public OrderDetail()
        {
            Order = new Order();
            Product = new Product();
        }

        [MaxLength(50)]
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal SubtotalPrice { get; set; }

        // Relations

        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
