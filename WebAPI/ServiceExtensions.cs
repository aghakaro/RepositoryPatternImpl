using Contracts.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository.RepositoryWrapper;

namespace WebAPI
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}