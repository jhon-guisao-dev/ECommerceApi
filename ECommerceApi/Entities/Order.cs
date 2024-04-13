using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Data
{
    public class Order : BaseEntity
    {
        public Order()
        {
            Customer = new Customer();
        }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        [MaxLength(50)]
        public string CustomerName { get; set; } = string.Empty;
        [MaxLength(100)]
        public string AddressToDeliver { get; set; } = string.Empty;

        // Relations

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
