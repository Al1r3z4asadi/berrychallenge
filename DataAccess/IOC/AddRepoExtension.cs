using berry.core.DataService;
using DataAccess.Config;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace DataAccess.IOC
{
    public static  class AddRepoExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
