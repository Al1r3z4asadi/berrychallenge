
using Api.common.Extensions;
using berry.core.ApplicationService;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerFacade;

        public CustomerController(ICustomerService customerFacade)
        {
            _customerFacade = customerFacade; 
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            Log.Information("get all customers");
            var customers = await _customerFacade.getAllCustomers();
            return Ok(customers.WrapResponse(Request.Path));
        }
    }
}
