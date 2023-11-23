using Api.common.Extensions;
using berry.core.ApplicationService;
using berry.core.DomainService.IOC;
using berry.facade;
using DataAccess.IOC;

namespace berry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
            builder.Services.AddDomainService();
            builder.Services.AddControllers();
            builder.Services.AddScoped<ICustomerService,CustomerFacade>();
            builder.Services.ConfigureApiOptions();
            builder.Services.AddPersistence();

            var app = builder.Build();

            if(app.Environment.IsDevelopment())
            {

            }


            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}