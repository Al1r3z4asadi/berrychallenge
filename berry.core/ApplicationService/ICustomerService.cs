

using berry.core.DTOs;

namespace berry.core.ApplicationService
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> getAllCustomers();
    }
}
