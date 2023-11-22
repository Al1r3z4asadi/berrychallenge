using berry.core.DataService;

namespace berry.core.DomainService
{
    public interface IUnitOfWork : IDisposable
    {
            
        ICustomerRepository customerRepository { get; }
        Task SaveChangesAsync();
    }
}

