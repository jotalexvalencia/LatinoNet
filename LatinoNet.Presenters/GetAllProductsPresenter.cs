using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public class GetAllProductsPresenter : 
        IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
    {
        public IEnumerable<ProductDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDTO> products)
        {
            Content = products;

            return Task.CompletedTask;
        }
    }
}
