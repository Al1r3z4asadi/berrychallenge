using Microsoft.Extensions.DependencyInjection;

namespace berry.core.DomainService.IOC
{
    public static class DomainServiceExtension
    {
        public static IServiceCollection AddDomainService(this IServiceCollection services)
        {
            services.AddScoped<CustomerDomainService>();
            return services;
        }
    }
}
