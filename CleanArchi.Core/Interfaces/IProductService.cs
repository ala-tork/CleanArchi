using CleanArchi.Core.DTO;
using CleanArchi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Core.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);

        Task<Product> Add(ProductDto prod);

        Task<Product> Update(int id, ProductDto prod);

        Task<Product> Delete(int id);

        Task<List<Product>> Search(DateTime start, DateTime end);
    }
}
