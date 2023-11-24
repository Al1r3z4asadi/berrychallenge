using berry.core.DTOs;

namespace berry.core.ApplicationService
{
    public interface ICustomerService
    {
        Task AddCutomer(CustomerDto customer);
        Task<IEnumerable<CustomerDto>> getAllCustomers();
    }
}
