using MediatR;
using MediatR_Example.Models;

namespace MediatR_Example.Queries
{
    public record GetProductsQuery:IRequest<IEnumerable<Product>>;
    
}
