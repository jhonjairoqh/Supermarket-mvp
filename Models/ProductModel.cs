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
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Product Price is required")]
        [Range(0, 9999.99, ErrorMessage = "Price must be between 0 and 9999.99")]
        public decimal Price { get; set; }  

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Stock must be at least 1")]
        public int Stock { get; set; }  

        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Category Id is required")]
        public int Category_Id { get; set; }
    }
}
