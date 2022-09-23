using MediatR;
using MediatR_CQRS.Models;

namespace MediatR_CQRS.Application.Commands
{
    public class CreateCustomerCommand:IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
