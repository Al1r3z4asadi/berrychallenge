using berry.core.ApplicationService;
using berry.core.DomainService;
using berry.core.DTOs;

namespace berry.facade
{
    public class CustomerFacade : ICustomerService
    {
        private readonly CustomerDomainService _customerService;

        public CustomerFacade(CustomerDomainService customerService)
        {
            _customerService = customerService;
        }   

        public Task<IEnumerable<CustomerDto>> getAllCustomers()
        {
            return _customerService.getAllCustomers();
        }
    }
}
