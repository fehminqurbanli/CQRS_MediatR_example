namespace MediatR_CQRS.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; } = string.Empty;
    }
}
