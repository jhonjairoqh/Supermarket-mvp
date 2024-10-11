using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();

        IEnumerable<ProductModel> GetByValue(string searchValue);
        void Add(ProductModel product);
        void Edit(ProductModel product);
        void Delete(int productId);
    }
}
