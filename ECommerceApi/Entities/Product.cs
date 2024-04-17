namespace ECommerceApi.Data
{
    using System.ComponentModel.DataAnnotations;

    public class Product : BaseEntity
    {
        public Product()
        {
            ProductCategories = new List<ProductCategory>();    
        }

        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [MaxLength(300)]
        public string Description { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public int Stock { get; set; }

        //Relations

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
