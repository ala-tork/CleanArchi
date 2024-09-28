using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Core.DTO
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Should Be Positive")]
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        [ForeignKey("Id")]
        public int CategoryId { get; set; }

        [Required]
        public DateTime DateAjout { get; set; }

        public DateTime DateMAJ { get; set; }
    }
}
