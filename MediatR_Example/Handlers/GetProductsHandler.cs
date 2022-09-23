using MediatR;
using MediatR_Example.Data;
using MediatR_Example.Models;
using MediatR_Example.Queries;

namespace MediatR_Example.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {

        private readonly FakeDataStore _fakeDataStore;

        public GetProductsHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) =>
            await _fakeDataStore.GetAllProducts();
        
    }
}
