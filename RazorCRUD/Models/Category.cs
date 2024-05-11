using System.ComponentModel.DataAnnotations;

namespace RazorCRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Display order is required")]
        public string DisplayOrder { get; set; }
    }
}
