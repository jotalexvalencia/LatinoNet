using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort InputPort;
        readonly ICreateProductOutputPort OutputPort;

        public CreateProductController(ICreateProductInputPort inputPort,
            ICreateProductOutputPort outputPort) =>        
            (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(
            CreateProductDTO product)
        {
            await InputPort.Handle(product);
            return ((IPresenter<ProductDTO>)OutputPort).Content;
        }
        
    }
}
