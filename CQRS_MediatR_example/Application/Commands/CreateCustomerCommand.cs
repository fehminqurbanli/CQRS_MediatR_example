using CQRS_MediatR_example.Models;
using MediatR;

namespace CQRS_MediatR_example.Application.Commands
{
    public class CreateCustomerCommand:IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
