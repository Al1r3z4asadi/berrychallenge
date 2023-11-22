
using berry.facade;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerFacade _customerFacade;

        public CustomerController(CustomerFacade customerFacade)
        {
            _customerFacade = customerFacade; 
        }

        public void GetAllCustomers()
        {
            
        }
    }
}
