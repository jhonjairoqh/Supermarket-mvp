using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Product Price is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product Price must be between 3 and 200 characters")]
        public string Price { get; set; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product Stock must be between 3 and 200 characters")]
        public string Stock { get; set; }

        [DisplayName("Category_Id")]
        [Required(ErrorMessage = "Product Category_Id  is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product Category_Id must be between 3 and 200 characters")]
        public string Category_Id { get; set; }
    }
}
