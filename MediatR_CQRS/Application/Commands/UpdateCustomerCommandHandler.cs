using MediatR;
using MediatR_CQRS.Models;
using MediatR_CQRS.Repositories;

namespace MediatR_CQRS.Application.Commands
{
    public class UpdateCustomerCommandHandler:IRequestHandler<UpdateCustomerCommand,Customer>
    {
        private readonly IRepository<Customer> _repository;

        public UpdateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            
            return await _repository.UpdateAsync(request.Customer);
        }
    }
}
