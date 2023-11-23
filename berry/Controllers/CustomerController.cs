
using Api.common.Extensions;
using berry.core.ApplicationService;
using berry.facade;
using Microsoft.AspNetCore.Mvc;

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
            var customers = await _customerFacade.getAllCustomers();
            return Ok(customers.WrapResponse(Request.Path));
        }
    }
}
