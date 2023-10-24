using LatinoNet.DTOs;
using System.Threading.Tasks;

namespace LatinoNet.UseCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
