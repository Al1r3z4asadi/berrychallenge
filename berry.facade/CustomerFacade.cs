using berry.core.ApplicationService;
using berry.core.DomainService;
using berry.core.DTOs;
using berry.facade.MapperExtension;

namespace berry.facade
{
    public class CustomerFacade : ICustomerService
    {
        private readonly CustomerDomainService _customerService;

        public CustomerFacade(CustomerDomainService customerService)
        {
            _customerService = customerService;
        }

        public async Task AddCutomer(CustomerDto customer)
        {
            await _customerService.AddCustomer(customer.ToEntity());
        }

        public async Task<IEnumerable<CustomerDto>> getAllCustomers()
        {
            return await _customerService.getAllCustomers();
        }
    }
}
