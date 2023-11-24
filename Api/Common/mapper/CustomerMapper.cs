using Api.Models.Requests;
using berry.core.DTOs;

namespace Api.Common.mapper
{
    public static class CustomerMapper
    {

        public static CustomerDto ToDto(this AddCustomerRequest addCustomerRequest)
        {
            return new CustomerDto
            {
                Name = addCustomerRequest.Name
                ?? throw new NullReferenceException($"{nameof(addCustomerRequest.Name)} Was Null"),
            };
        }
        public static CustomerDto ToDto(this RenameCustomerRequest renameCustomerRequest)
        {
            return new CustomerDto
            {
                Id = renameCustomerRequest.CustomerId
                ?? throw new NullReferenceException($"{nameof(renameCustomerRequest.CustomerId)} Was Null"),
                Name = renameCustomerRequest.Name
            };
        }
    }
}
