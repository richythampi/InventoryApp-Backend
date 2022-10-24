using System.ComponentModel.DataAnnotations;

namespace InventoryAppAPI
{
    public class ProductInfo
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public ProductCategories Category { get; set; }
        public int CategoryId { get; set; }

        public int ProductCount { get; set; }

        public UserInfo User { get; set; }

        public int UserId { get; set; }

        public DateTime LastUpdatedOn { get; set; }


    }
}
