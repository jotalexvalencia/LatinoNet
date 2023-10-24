using LatinoNet.RepositoryEFCore.DataContext;
using LatinoNet.RepositoryEFCore.Repositories;
using LatinoNET.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LatinoNet.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<LatinoNetContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("LatinoNet")));

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
