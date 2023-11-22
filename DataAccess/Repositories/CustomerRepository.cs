using berry.core.DataService;
using berry.core.DomainObjects.customer;

namespace DataAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Customer item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Customer updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
