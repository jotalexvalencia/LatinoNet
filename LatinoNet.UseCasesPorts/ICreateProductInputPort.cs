using LatinoNet.DTOs;
using System.Threading.Tasks;

namespace LatinoNet.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}
