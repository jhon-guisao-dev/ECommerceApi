namespace ECommerceApi.Data
{
    using System.ComponentModel.DataAnnotations;

    public class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(300)]
        public string Description { get; set; } = string.Empty;

        //Relations

        public ICollection<Product> Products { get; set; }
    }
}
