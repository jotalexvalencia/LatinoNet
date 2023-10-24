using LatinoNet.UseCases.CreateProduct;
using LatinoNet.UseCases.GetAllProducts;
using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace LatinoNet.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort,
                CreateProductInteractor>();

            services.AddTransient<IGetAllProductsInputPort,
                GetAllProductsInteractor>();

            return services;
        }
    }
}
