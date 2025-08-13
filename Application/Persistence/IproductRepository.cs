using Domain.Entity;
using Domain.IGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence
{
    public interface IproductRepository: IGeneric<ProductUpdate>
    {
        //Task<Product> GetProduct(int id);
        //Task<IEnumerable<Product>> GetAllProductsAsync();
        //Task<Product> AddProduct(Product product);s

        //Task<Product> DeleteProduct(Product product);
        //Task<Product> UpdateProduct(Product product);
    }
}
