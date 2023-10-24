using LatinoNet.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LatinoNet.UseCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDTO> products);
    }
}
