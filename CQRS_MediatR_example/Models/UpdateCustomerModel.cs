using System.ComponentModel.DataAnnotations;

namespace CQRS_MediatR_example.Models
{
    public class UpdateCustomerModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; } = string.Empty;
    }
}
