using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1,ErrorMessage ="Product Name must be at Least 1 Character.")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Range(0,double.MaxValue,ErrorMessage ="Price must be Positive Value.")]
        public decimal Price { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }
    }
}
