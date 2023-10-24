using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public class CreateProductPresenter :
        ICreateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
