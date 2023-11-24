using berry.core.DomainObjects.customer;
using berry.core.DTOs;

namespace berry.facade.MapperExtension
{
    public static  class CustomerMappingExtension
    {
        public static CustomerDto ToDto(this Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name,
            };
        }

        public static IEnumerable<CustomerDto> Project(this IEnumerable<Customer> customers)
            => customers.Select(b => b.ToDto());

        public static Customer ToEntity(this CustomerDto customerDto)
        {
            return new Customer
            {
                Id = customerDto.Id,    
                Name = customerDto.Name,
            };
        }
    }
}
