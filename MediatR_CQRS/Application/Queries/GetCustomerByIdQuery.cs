using MediatR;
using MediatR_CQRS.Models;

namespace MediatR_CQRS.Application.Queries
{
    public class GetCustomerByIdQuery:IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
