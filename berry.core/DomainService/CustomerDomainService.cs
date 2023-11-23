using berry.core.DataService;
using berry.core.DTOs;
using berry.facade.MapperExtension;

namespace berry.core.DomainService
{
    public class CustomerDomainService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerDomainService(ICustomerRepository customerRepository) { 
            this._customerRepository = customerRepository;  
        }
        public async Task<IEnumerable<CustomerDto>> getAllCustomers()
        {
            var customers = await _customerRepository.GetAllAsync();
            return customers.Project();
        }
    }
}
