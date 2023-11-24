
using Api.common.Extensions;
using Api.Common.mapper;
using Api.Models.Requests;
using berry.core.ApplicationService;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Api.Controllers
{
    [Route("api/v1/[controller]")]
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

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerRequest request)
        {
            var customer = request.ToDto();
            await _customerFacade.AddCutomer(customer);
            return Created(Request.Path, customer.WrapResponse(Request.Path));
        }

        [HttpPut]
        public async Task<IActionResult> RenamCustomer([FromBody] RenameCustomerRequest request)
        {
            var customer = request.ToDto();
            await _customerFacade.EditCustomerName(customer);
            return Created(Request.Path, customer.WrapResponse(Request.Path));
        }

    }
}
