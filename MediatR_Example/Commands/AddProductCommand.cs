using MediatR;
using MediatR_Example.Models;

namespace MediatR_Example.Commands
{
    public record AddProductCommand(Product Product):IRequest<Product>;

}
