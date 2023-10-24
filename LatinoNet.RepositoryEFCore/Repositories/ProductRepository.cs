using LatinoNet.RepositoryEFCore.DataContext;
using LatinoNET.Entities.Interfaces;
using LatinoNET.Entities.POCOs;
using System.Collections.Generic;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly LatinoNetContext Context;
        public ProductRepository(LatinoNetContext context) =>
            Context = context;
        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return Context.Products;
        }
    }
}
