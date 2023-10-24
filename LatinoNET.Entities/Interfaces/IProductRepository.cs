using LatinoNET.Entities.POCOs;
using System.Collections.Generic;

namespace LatinoNET.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}
