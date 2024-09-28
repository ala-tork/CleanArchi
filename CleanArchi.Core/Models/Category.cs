using System.ComponentModel.DataAnnotations;

namespace CleanArchi.Core.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Category Name Is Required !!")]
        public string Name { get; set; }

        public string Description { get; set; }
        public List<Product> Products { get; set; }

    }
}
