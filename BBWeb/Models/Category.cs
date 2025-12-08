using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BBWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "(1-10)")]
        [DisplayName("Category Name")]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "(1-100)")]
        public int DisplayOrder { get; set; }
    }
}
