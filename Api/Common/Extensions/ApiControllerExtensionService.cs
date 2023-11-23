using Microsoft.AspNetCore.Mvc;

namespace Api.common.Extensions
{
    public static  class ApiControllerExtensionService
    {
        public static void ConfigureApiOptions(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(c =>
            {
                c.InvalidModelStateResponseFactory =
                e => new BadRequestObjectResult(new ErrorResponse(e.ModelState, e.HttpContext.Request.Path));
            });
        }

    }
}
