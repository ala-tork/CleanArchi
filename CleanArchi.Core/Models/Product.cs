using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchi.Core.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name Is Required!!")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        [ForeignKey("Id")]
        [Required(ErrorMessage ="You Should Add Category To Product !!")]
        public int  CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime DateAjout { get; set; }
        
        public DateTime DateMAJ { get; set; }
    }
}
