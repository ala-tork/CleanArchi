using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Core.DTO
{
    public class CategoryDto
    {
        [Required(ErrorMessage = "Category Name Is Required")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
