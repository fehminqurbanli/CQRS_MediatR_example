using MediatR;
using MediatR_Example.Models;

namespace MediatR_Example.Queries
{
    public record GetProductByIdQuery(int id):IRequest<Product>;
  
}
