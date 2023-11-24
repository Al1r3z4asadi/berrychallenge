using System.ComponentModel.DataAnnotations;

namespace Api.Models.Requests
{
    public class RenameCustomerRequest
    {
        [Required]
        public String CustomerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
