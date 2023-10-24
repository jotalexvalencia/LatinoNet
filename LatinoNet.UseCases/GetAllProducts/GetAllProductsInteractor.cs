using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;
using LatinoNET.Entities.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetAllProductsOutputPort OutputPort;

        public GetAllProductsInteractor(IProductRepository repository, 
            IGetAllProductsOutputPort outputPort) =>
            (Repository, OutputPort) = (repository,outputPort);
        

        public Task Handle()
        {
            var Products = Repository.GetAll().Select(p =>
            new ProductDTO
            {
                Id = p.Id,
                Name = p.Name
            });

            OutputPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
