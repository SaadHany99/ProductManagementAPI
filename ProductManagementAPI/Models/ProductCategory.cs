using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementAPI.Models
{
    public class ProductCategory
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
