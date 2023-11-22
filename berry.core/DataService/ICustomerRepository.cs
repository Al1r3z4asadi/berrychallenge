using berry.core.DomainObjects.customer;

namespace berry.core.DataService
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(string id);
        Task InsertAsync(Customer item);
        Task UpdateAsync(string id, Customer updatedItem);
        Task DeleteAsync(string id);
    }
}
