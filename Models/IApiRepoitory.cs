using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrGer.Models
{
    internal interface IApiRepoitory
    {
         Task<ProductModel> GetAll();
        Task<int> Add(ProductModel productModel);
        Task<ProductModelJson> Update(ProductModel productModel);
        Task<bool> Delete(int id);

    }
}
