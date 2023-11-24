using berry.core.DataService;
using berry.core.DomainObjects.customer;
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

        public async Task AddCustomer(Customer customer)
        {
            await _customerRepository.InsertAsync(customer);
        }

        public async Task DeleteCustomer(string id)
        {
            await _customerRepository.DeleteAsync(id);  
        }

        public async Task EditCustomerName(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer.Id, customer);
        }

        public async Task<IEnumerable<CustomerDto>> getAllCustomers()
        {
            var customers = await _customerRepository.GetAllAsync();
            return customers.Project();
        }
    }
}
