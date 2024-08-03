using System.ComponentModel.DataAnnotations;

namespace Asp_Razor_Page.Entities
{
    public class Product
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Description { get; set; }
        [Range(1,10000,ErrorMessage ="Price should be between 1-10000")]
        public decimal Price { get; set; }
        [Range(0, 100, ErrorMessage = "Price should be between 0-100")]
        public int Discount { get; set; }
    }
}
