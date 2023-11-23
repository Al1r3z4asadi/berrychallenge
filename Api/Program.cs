using Api.common.Extensions;
using Api.Middlewares;
using berry.core.ApplicationService;
using berry.core.DomainService.IOC;
using berry.facade;
using DataAccess.IOC;
using Serilog;

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


            Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                 .CreateLogger();

            var app = builder.Build();

            if(app.Environment.IsDevelopment())
            {

            }
            app.UseMiddleware<ExceptionHandlerMiddleware>();


            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}