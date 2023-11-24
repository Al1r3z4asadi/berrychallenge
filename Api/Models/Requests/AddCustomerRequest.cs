using System.ComponentModel.DataAnnotations;

namespace Api.Models.Requests
{
    public class AddCustomerRequest
    {

        [Required]
        public string Name { get; set; }
    }
}
