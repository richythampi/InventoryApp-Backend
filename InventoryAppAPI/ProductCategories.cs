using System.ComponentModel.DataAnnotations;

namespace InventoryAppAPI
{
    public class ProductCategories
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public List<ProductInfo> Products { get; set; }

    }
}
