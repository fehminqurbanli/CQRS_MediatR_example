using MediatR;
using MediatR_Example.Models;

namespace MediatR_Example.Nontification
{
    public record ProductAddedNontification(Product Product):INotification;

}
