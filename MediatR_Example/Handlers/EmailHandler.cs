using MediatR;
using MediatR_Example.Data;
using MediatR_Example.Nontification;

namespace MediatR_Example.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNontification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public EmailHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductAddedNontification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
