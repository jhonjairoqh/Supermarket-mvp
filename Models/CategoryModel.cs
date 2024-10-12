using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    class CategoryModel
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        public string Description { get; set; }
    }
}
