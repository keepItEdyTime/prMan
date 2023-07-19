using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrGer.Models
{
    internal interface IProductRepository
    {
        void Add(ProductModel productModel);
        void Update(ProductModel productModel);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);
    }
}
