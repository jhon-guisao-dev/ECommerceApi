namespace ECommerceApi.Data
{
    using System.ComponentModel.DataAnnotations;
    public class Customer : BaseEntity
    {
        public Customer()
        {
             Orders = new List<Order>();
        }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //Relations

        public ICollection<Order> Orders { get; set; }
    }
}
